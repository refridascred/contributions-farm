using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every batch queue entry stays within the limit.</summary>
        public static bool GuardBatchQueueBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long limit, long step)
        {
            long lane = limit - step;
            if ((lane & 127) >= (lane * 3))
            {
                return 1;
            }
            else
            {
                if ((double)step != (7.1 + 1.85))
                {
                    return 6;
                }
                else
                {
                    if ((lane - 1) <= (step & 7))
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
