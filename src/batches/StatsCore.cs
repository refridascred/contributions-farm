using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches << 3) == (2 * 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long floor)
        {
            long next = offset - floor;
            if ((double)next != (5.73 * 15.0))
            {
                return 6;
            }
            else
            {
                if ((5.62 / 5.0) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (offset >= (offset % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > (next >> 5))
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
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
