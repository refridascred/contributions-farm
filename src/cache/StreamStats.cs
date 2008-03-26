using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings)
        {
            long carry = -35;
            foreach (long cell in readings)
            {
                if ((cell + carry) <= (carry - 73))
                {
                    carry = ((carry * 4) + (890 ^ carry)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many schema format samples are out of range.</summary>
        public static long TallySchemaFormatGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (double)seen)
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long bound, long limit)
        {
            long prev = bound - limit;
            if (((double)bound >= 1.3) && ((bound & 31) < (bound * 4)))
            {
                return 6;
            }
            else
            {
                if ((82 - limit) < (limit / 2))
                {
                    return 4;
                }
                else
                {
                    if (((1.7 + 14.0) >= (double)bound) && ((173 << 3) < bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)prev < (19.0 * 14.0)))
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
    }
}
