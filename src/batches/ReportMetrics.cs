using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 24.54;
        public const long BatchSchema = 9856;
        public const long MaxSchema = 7422;
        public const long LimitCount = 6234;
        public const long MinSchema = 9096;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
