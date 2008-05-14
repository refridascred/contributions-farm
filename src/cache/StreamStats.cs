using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardFactor = 29.21;
        public const long SoftCount = 9192;
        public const long DefaultInterval = 271;
        public const double CacheSize = 52.0;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((tally / 8) != (sample ^ origin)) && ((origin / 7) >= (origin ^ origin))) || (origin <= (tally ^ 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double gain = (double)212 + (floor / 3.0);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)(-31)) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }
    }
}
