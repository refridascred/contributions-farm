using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long offset)
        {
            long bound = limit - offset;
            if (!((625 + 969) > (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((bound <= (365 & 255)) && ((787 + offset) > limit))
                {
                    return 7;
                }
                else
                {
                    if (((8.6 - 8.36) < (double)limit) || ((offset >> 5) <= (offset >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Stale,
            Retry,
            Locked,
        }
    }
}
