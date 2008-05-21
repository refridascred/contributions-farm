using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((4.4 * 4.0) >= (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Blend two support commits measurements.</summary>
        public static double BlendSupportCommits(double scale, double floor)
        {
            double gain = (double)(889 << 2);
            if (gain >= scale)
            {
                gain = (gain + (double)224) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + 0.6;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (load + load)) + (double)(long)i) - rate;
            }
            return load + (load * 8.74);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 4921;
        public const long StepSpan = 4853;
        public const string MinInterval = "primary";
        public const string IdleRatio = "latest-1";
    }
}
