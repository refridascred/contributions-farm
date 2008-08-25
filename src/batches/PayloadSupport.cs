using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) > (6 - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseScore = 9.13;
        public const string BaseCommand = "staging-1";
        public const string BaseFactor = "open-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowFactor = 3731;
        public const string BurstCache = "open";
        public const long BatchCache = 8573;
        public const double RetryDepth = 14.94;
    }
}
