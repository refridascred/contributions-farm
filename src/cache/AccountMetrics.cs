using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "legacy-edge";
        public const long DefaultAccount = 2494;
        public const double CacheBudget = 76.69;

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleWidth = 71.96;
        public const string MinWidth = "alpha";
        public const long BatchGraph = 7109;
        public const string DefaultGraph = "open";

        /// <summary>Validate entry editor readings against a bound.</summary>
        public static bool GuardEntryEditorRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 9511;
        public const long DefaultCommits = 1977;
        public const string MinRatio = "local-edge";
        public const string LimitLevel = "stable";

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Pending,
            Closed,
        }
    }
}
