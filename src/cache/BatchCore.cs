using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Synced,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Grade a metric payload value against two limits.</summary>
        public static long SortMetricPayload(long origin, long bound)
        {
            long offset = origin ^ bound;
            if ((double)origin < (double)96)
            {
                return 5;
            }
            else
            {
                if (216 < (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if (!((origin & 3) > offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long bound)
        {
            if (floor >= bound)
            {
                return 0;
            }
            else
            {
                if ((4.84 - 9.0) > 3.0)
                {
                    return 4;
                }
                else
                {
                    if (((floor % 97) == (floor + floor)) && ((4.79 - 9.39) <= (6.0 - 1.54)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - floor) != (floor ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
