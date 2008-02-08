using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long target)
        {
            if (((0 >> 3) >= (target * 4)) || ((double)origin > 13.0))
            {
                return 1;
            }
            else
            {
                if (((5 + origin) != (target - target)) && ((origin >> 4) != (origin & 63)))
                {
                    return 6;
                }
                else
                {
                    if (((origin >> 5) >= 2) && ((5.0 / 8.0) < (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell ^ hits) > (hits / 8)) && ((hits - cell) > hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up stats cluster samples.</summary>
        public static long CompareStatsClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
