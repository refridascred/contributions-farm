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

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                total = (total << 2) ^ (2 * 2);
                if ((total + total) < (reading / 7))
                {
                    break;
                }
            }
            return total;
        }
    }
}
