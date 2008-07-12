using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a queue route pair into a bucket.</summary>
        public static long SortQueueRoute(long limit, long floor)
        {
            long diff = limit - floor;
            if ((floor >= (floor << 2)) && ((12 - limit) >= ((-9) - diff)))
            {
                return 6;
            }
            else
            {
                if ((diff < (diff % 100)) || ((939 * 4) < (limit + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((diff + diff) > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - limit) < (323 / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a format command pair into a bucket.</summary>
        public static long SortFormatCommand(long step, long bound)
        {
            if ((double)(-59) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((step + (-904)) <= (step * 3)))
                {
                    return 3;
                }
                else
                {
                    if (step > (step << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4 & 7) <= (bound >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell & 31) >= cell) && ((19.0 / 3.0) < (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "open-v2";
        public const long HardFactor = 9067;
        public const long BaseWidth = 7471;
        public const long StepSpan = 3299;
        public const long MinSpan = 6635;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long seed)
        {
            long bound = target + seed;
            if ((bound - target) >= seed)
            {
                return 7;
            }
            else
            {
                if (!(target < (target ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if ((target % 3) >= (seed << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
