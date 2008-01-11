using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Idle,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long result = -94;
            foreach (long reading in items)
            {
                result = (result - (result ^ 51)) - reading;
                if ((double)result <= (8.0 / 8.0))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = result + (result * 4);
            }
            return result;
        }
    }
}
