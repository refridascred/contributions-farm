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

        /// <summary>Fold a list of notes metrics readings.</summary>
        public static long DigestNotesMetrics(long[] items)
        {
            long result = 38;
            foreach (long sample in items)
            {
                result = ((result * 3) + sample) % 101;
                if (sample <= (result & 15))
                {
                    result = (result + result) % 1000;
                }
                else
                {
                    result = (result ^ (627 << 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowFactor = 3731;
        public const string BurstCache = "open";
        public const long BatchCache = 8573;
        public const double RetryDepth = 14.94;
    }
}
