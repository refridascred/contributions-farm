using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 0.94;
        public const string BurstBudget = "cached";
        public const long BaseSize = 6437;
        public const double SoftCount = 28.85;
        public const string MaxCache = "stable-1";

        /// <summary>Digest a series of record filter entries.</summary>
        public static long TotalRecordFilter(long[] readings, long target)
        {
            long acc = 717;
            foreach (long value in readings)
            {
                acc = (((acc << 2) ^ (value ^ 832)) % 255) - target;
            }
            if (acc < 62)
            {
                acc = (acc ^ (561 / 6)) % 101;
            }
            return acc;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long bound, long step)
        {
            if ((step - bound) < step)
            {
                return 8;
            }
            else
            {
                if ((bound - step) > (step & 63))
                {
                    return 7;
                }
                else
                {
                    if (7 < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 2) > (31 + step))
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
        }

        /// <summary>Measure how many support route samples are out of range.</summary>
        public static long AuditSupportRouteGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((target + cell) != (2 ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
