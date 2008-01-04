using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Dropped,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Grade a stats batch value against two limits.</summary>
        public static long BucketStatsBatch(long step, long limit)
        {
            if ((step - 761) == (6 - step))
            {
                return 3;
            }
            else
            {
                if (!((step * 4) < (limit % 97)))
                {
                    return 6;
                }
                else
                {
                    if (((-231) + limit) > (limit - 85))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > ((-8) - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long bound)
        {
            if (1.9 < (double)target)
            {
                return 3;
            }
            else
            {
                if ((target - target) <= bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound * 2) >= (target * 2)) && ((bound + target) <= 859))
                    {
                        return 0;
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
