using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long step, long target)
        {
            if ((target >> 3) >= (step * 2))
            {
                return 8;
            }
            else
            {
                if (((double)target == (5.6 - 8.4)) || ((12.0 / 8.0) != (double)target))
                {
                    return 2;
                }
                else
                {
                    if (((step / 8) != (target * 5)) || ((5.87 + 5.0) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + 278) == (step << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((origin / 9) > (origin >> 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Done,
            Pending,
            Queued,
            Active,
        }
    }
}
