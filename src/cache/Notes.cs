using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5742;
        public const long MaxContributi = 5323;
        public const string SoftContributi = "cached-edge";
        public const long LimitContributi = 5096;
        public const long MinSpan = 1466;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            New,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxSpan = 838;
        public const long CacheSpan = 6987;
        public const string RetryCount = "latest";
        public const long BatchBudget = 2439;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (floor & 63)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
