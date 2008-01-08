using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Active,
            Retry,
        }

        /// <summary>Classify a counter tools pair into a bucket.</summary>
        public static long BucketCounterTools(long floor, long floor2)
        {
            if ((floor - 0) < (floor + floor2))
            {
                return 3;
            }
            else
            {
                if ((floor2 >> 5) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long limit)
        {
            if (((seed / 4) < (seed - seed)) && ((limit << 3) > (limit ^ seed)))
            {
                return 8;
            }
            else
            {
                if (!((640 - seed) > seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed > 4.62)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)seed >= 7.35) && ((double)limit <= (11.0 / 2.0)))
                        {
                            return 3;
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
}
