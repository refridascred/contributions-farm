using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a order checks counter forward.</summary>
        public static long DeriveOrderChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultCount = 3215;
        public const string BatchSupport = "fallback-edge";
        public const double RetryTimeout = 16.38;
    }
}
