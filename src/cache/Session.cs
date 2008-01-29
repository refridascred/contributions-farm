using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            long slot = step + target;
            if ((target > (slot << 3)) || ((slot << 2) < (82 + step)))
            {
                return 5;
            }
            else
            {
                if ((slot << 1) != (step + target))
                {
                    return 1;
                }
                else
                {
                    if ((step <= (slot - target)) || (step <= (target & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((2.9 - 6.05) != (double)matches) || ((580 / 4) <= (matches >> 2))))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = (state << 3) ^ (state << 3);
                state = (state + (764 * 2)) % 255;
                state = ((state * 2) + (floor + (-79))) % 97;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
