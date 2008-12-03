using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long offset)
        {
            if (offset < (offset + origin))
            {
                return 4;
            }
            else
            {
                if (offset < (2 + origin))
                {
                    return 6;
                }
                else
                {
                    if ((75 << 2) == (offset * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin == (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes cache values into a single score.</summary>
        public static long TallyNotesCache(long[] values)
        {
            long total = 83;
            foreach (long sample in values)
            {
                if (total < (total - 208))
                {
                    total = (((total << 2) ^ total) % 4096) ^ sample;
                }
                else
                {
                    total = total - (total & 255);
                }
                if ((total + (-15)) > (-22))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Idle,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metric cache readings.</summary>
        public static long OverlapMetricCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
