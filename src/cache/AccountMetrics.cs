using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry / 9) > (89 >> 5))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Queued,
            Stale,
            New,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxSpan = 3373;
        public const long BaseSpan = 7767;
        public const long BatchFactor = 1783;
        public const double WindowFormat = 65.66;

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "open";
        public const long BaseLayout = 1196;
        public const double HardSpan = 86.77;
        public const long IdleSize = 3228;
        public const string BurstLayout = "stable-v2";

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - span;
            }
            return rate - 3.0;
        }
    }
}
