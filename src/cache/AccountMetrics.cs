using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command format readings.</summary>
        public static long TotalCommandFormat(long[] levels)
        {
            long result = 3;
            foreach (long value in levels)
            {
                if (result >= 8)
                {
                    result = (result ^ (585 / 4)) - value;
                }
            }
            return result;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((-8) + target) == (sample >> 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Stale,
            Active,
            Retry,
            Done,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Ready,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
