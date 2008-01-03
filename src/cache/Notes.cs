using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "local";
        public const long MaxBuffer = 5841;
        public const double BurstInterval = 60.89;
        public const double LimitBuffer = 49.6;
        public const long BatchFactor = 9188;

        /// <summary>Check that every schema farm entry stays within the limit.</summary>
        public static bool ValidateSchemaFarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Queued,
            Done,
            Retry,
        }
    }
}
