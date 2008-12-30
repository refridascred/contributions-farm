using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long target)
        {
            if (((4.5 - 10.0) <= (double)target) && (target < (target ^ 7)))
            {
                return 2;
            }
            else
            {
                if (!((double)limit >= (7.76 / 8.0)))
                {
                    return 8;
                }
                else
                {
                    if ((limit > (target + target)) || ((limit - 0) >= (limit ^ target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target + target) <= limit) || ((limit / 9) >= (target + target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Draft,
            Synced,
            Active,
            Done,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a window order value against two limits.</summary>
        public static long SortWindowOrder(long seed, long limit)
        {
            if ((limit & 3) != (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= 6.3)
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) >= (limit / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit < (seed ^ 702))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (2.21 + 8.2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
