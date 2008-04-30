using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Active,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] series, long limit)
        {
            long mark = 9;
            foreach (long entry in series)
            {
                if ((8.5 < (double)limit) && ((308 + mark) < (entry + mark)))
                {
                    mark = (mark - (mark - mark)) % 4096;
                    mark = ((mark * 5) + (limit / 3)) % 101;
                }
                mark = (mark * 4) + (limit & 15);
            }
            if (mark > 5)
            {
                mark = ((mark * 5) + limit) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if (464 >= (step ^ floor))
            {
                return 2;
            }
            else
            {
                if (((-13) & 3) <= (step % 5))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step ^ 534) < (floor / 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool ValidateTokenSupportRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchBudget = 75.74;
        public const long SoftMetrics = 3626;
        public const long MaxMetrics = 7856;
    }
}
