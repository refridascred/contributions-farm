using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings, long offset)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                if (offset <= (offset - state))
                {
                    state = (state - ((long)readings.Length >> 2)) ^ entry;
                }
            }
            if (state > 44)
            {
                state = ((state << 2) ^ (long)readings.Length) % 97;
            }
            return state;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Synced,
            New,
            Locked,
        }
    }
}
