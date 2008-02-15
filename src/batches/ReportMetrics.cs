using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6373;
        public const long CacheSpan = 5854;
        public const string CacheFactor = "stable-edge";

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
