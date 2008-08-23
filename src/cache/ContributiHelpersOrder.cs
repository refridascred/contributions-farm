using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long FoldBufferCache(long[] data)
        {
            long total = 38;
            foreach (long sample in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (((total << 3) ^ (sample + total)) % 65521) + (long)i;
                }
                total = (total + ((long)data.Length - sample)) % 101;
            }
            if (total > 899)
            {
                total = (total - (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            if ((double)step <= 6.0)
            {
                return 7;
            }
            else
            {
                if (((seed % 8) > (step << 3)) || ((seed >> 4) <= (step + step)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 93.48;
        public const long MaxRecord = 9413;
        public const double IdleRecord = 76.3;
        public const long RetryRecord = 7442;
    }
}
