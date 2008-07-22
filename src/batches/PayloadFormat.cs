using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long floor)
        {
            long bound = seed - floor;
            if ((bound + seed) < (floor % 7))
            {
                return 6;
            }
            else
            {
                if ((floor + seed) > (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + bound) >= (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >= (4 ^ seed)) || ((3.89 / 7.0) != (double)bound))
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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (!((double)offset >= (double)bound2))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
