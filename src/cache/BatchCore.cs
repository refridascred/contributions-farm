using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((hits - cell) <= (cell - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long BucketProfileBuffer(long target, long limit)
        {
            long cur = target ^ limit;
            if (96 < (target % 2))
            {
                return 0;
            }
            else
            {
                if (target >= (target + 34))
                {
                    return 8;
                }
                else
                {
                    if ((target - target) > (limit * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)cur < 18.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Pending,
            Ready,
        }
    }
}
