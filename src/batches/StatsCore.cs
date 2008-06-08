using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many channel batches samples are out of range.</summary>
        public static long CountChannelBatchesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((445 << 1) > value) && ((12.0 * 0.41) == (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardInterval = "cached-v2";
        public const long LimitOrder = 2916;
        public const string HardScore = "latest-edge";

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long origin)
        {
            long result = 758;
            foreach (long item in data)
            {
                result = (((result + ((-3) + result)) % 255) - item) - origin;
            }
            return result % 65521;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ count) != (count / 9))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            New,
            Failed,
            Retry,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long seed, long origin)
        {
            if ((seed << 2) > (origin >> 5))
            {
                return 7;
            }
            else
            {
                if ((seed >= (30 - origin)) && ((double)origin < (1.0 + 12.0)))
                {
                    return 5;
                }
                else
                {
                    if (seed <= (seed * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= (origin >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
