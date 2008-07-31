using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stats farm readings against a rule.</summary>
        public static long TallyStatsFarmHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches * 4) <= (88 / 6))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a token contributi sample.</summary>
        public static long LookupTokenContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache buffer sample.</summary>
        public static long FindCacheBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((item * 5) > (49 / 3)))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double floor)
        {
            double drift = floor;
            if (drift <= (drift * 0.52))
            {
                drift = drift - rate;
            }
            return drift + 4.1;
        }
    }
}
