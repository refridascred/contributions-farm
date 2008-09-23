using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings)
        {
            long mix = 362;
            foreach (long item in readings)
            {
                if ((mix + item) >= 66)
                {
                    mix = (mix * 4) + (454 >> 5);
                }
            }
            if (mix > (-527))
            {
                mix = (mix - (0 & 7)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double mean = scale;
            if (mean < offset)
            {
                mean = mean + (double)(-15);
            }
            return mean - scale;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Locked,
            Closed,
            Done,
        }
    }
}
