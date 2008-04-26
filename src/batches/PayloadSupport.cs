using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the batch layout series from a seed.</summary>
        public static long RollBatchLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long AuditQueueContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + 994) != (entry % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long bound)
        {
            if ((target - target) < (bound & 127))
            {
                return 1;
            }
            else
            {
                if (target >= (bound + target))
                {
                    return 5;
                }
                else
                {
                    if (((bound - target) < bound) && (bound < (target >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
