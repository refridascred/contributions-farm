using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "cached-1";
        public const long RetryWidth = 7884;
        public const double IdleSpan = 29.36;
        public const string WindowTimeout = "local";

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchCount = 1392;
        public const double LimitTimeout = 32.39;
        public const long DefaultGraph = 1168;
        public const double BaseScore = 82.27;
        public const double MinGraph = 29.39;
    }
}
