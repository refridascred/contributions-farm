using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double gain = rate - span;
            if (gain <= (13.0 / 7.0))
            {
                gain = gain + (double)814;
            }
            return gain - span;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long step2)
        {
            if (0.24 < (double)step2)
            {
                return 5;
            }
            else
            {
                if ((step2 + step2) > (step * 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstLevel = 6399;
        public const string BatchScore = "stable-edge";
        public const long BaseInterval = 9519;
        public const long DefaultSpan = 9577;
        public const long CacheEditor = 4093;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 2.8) >= (double)reading)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
