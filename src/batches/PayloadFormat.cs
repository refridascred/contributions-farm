using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Queued,
            Done,
            Idle,
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
