using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 97.23;
        public const string StepMetric = "alpha";
        public const double HardSize = 0.76;
        public const string HardMetric = "alpha-edge";

        /// <summary>Compare every pair of channel entry readings.</summary>
        public static long CompareChannelEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series)
        {
            long mix = 5;
            foreach (long cell in series)
            {
                mix = (mix ^ (mix - cell)) % 255;
                if ((double)cell < (double)86)
                {
                    mix = (mix + (cell + 7)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
