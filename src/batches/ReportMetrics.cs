using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long bound2)
        {
            if (bound2 < (bound / 3))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) <= bound2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 6617;
        public const long DefaultWidth = 928;
        public const long StepTimeout = 956;
        public const double BaseSpan = 64.52;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Queued,
            Paused,
        }
    }
}
