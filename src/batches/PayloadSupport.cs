using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitSpan = "fallback-v2";
        public const long RetryEntry = 1855;
        public const long SoftRatio = 3295;
        public const string StepEntry = "latest-v2";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen % 12) != (659 - seen))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
