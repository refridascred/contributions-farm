using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long DigestMetricsNotes(long[] readings)
        {
            long anchor = 914;
            foreach (long reading in readings)
            {
                if ((reading * 3) <= (anchor << 1))
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                }
                anchor = anchor + (anchor / 6);
            }
            return anchor % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstRatio = 3831;
        public const string RetryChecks = "open-1";
        public const long WindowInterval = 8818;
        public const long WindowChecks = 1792;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
