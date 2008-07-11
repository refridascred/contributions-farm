using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine token format values into a single score.</summary>
        public static long CombineTokenFormat(long[] readings, long offset)
        {
            long state = 580;
            foreach (long item in readings)
            {
                state = (((state ^ 82) % 101) + item) - offset;
            }
            if (state < (-437))
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
