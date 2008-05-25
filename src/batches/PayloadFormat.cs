using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((2 - count) < 53) || ((10.0 + 2.9) < (double)cell)) && ((double)cell < 8.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = (state + (item - state)) % 101;
                if ((21 <= (item * 3)) || (207 < (item + state)))
                {
                    state = state - (item + item);
                }
                if ((291 ^ state) <= (1 / 6))
                {
                    break;
                }
            }
            if (state < 63)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Count { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
