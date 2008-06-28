using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)hits != (1.0 * 7.0)) || ((6.63 / 8.0) != (double)entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Retry,
            Active,
            Ready,
            Closed,
        }
    }
}
