using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long origin, long step)
        {
            if (2.19 > (double)step)
            {
                return 5;
            }
            else
            {
                if ((step - step) >= (step + origin))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 3021;
        public const long MaxInterval = 4889;
        public const long RetryMetrics = 9528;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (limit >= diff)
            {
                return 4;
            }
            else
            {
                if (((double)limit >= 8.58) || ((1 & 255) >= (bound % 60)))
                {
                    return 3;
                }
                else
                {
                    if (((-583) / 6) < (bound + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff < (7.4 - 6.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
