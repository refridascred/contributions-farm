using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long target)
        {
            if (!((target ^ target) >= target))
            {
                return 7;
            }
            else
            {
                if ((9 / 4) == (target - target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((double)limit2 != (8.2 + 6.43))
            {
                return 2;
            }
            else
            {
                if (gap < (gap >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit2 == (18.0 + 0.9))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit >= gap)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 2645;
        public const long BurstBuffer = 4936;
        public const long DefaultBuffer = 993;
        public const long LimitBuffer = 5663;
        public const long SoftRatio = 3201;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long target)
        {
            long step = bound - target;
            if (!((14.0 / 9.0) == (double)target))
            {
                return 7;
            }
            else
            {
                if ((step / 6) >= (step ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Done,
            Active,
            Paused,
        }
    }
}
