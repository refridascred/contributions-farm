using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length / 6) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Retry,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitBudget = 5349;
        public const long MinSpan = 3775;
        public const string BaseWindow = "standard-edge";
        public const long MinWindow = 4194;
        public const long DefaultWindow = 4894;
    }
}
