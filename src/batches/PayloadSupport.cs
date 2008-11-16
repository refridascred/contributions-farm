using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 5573;
        public const long IdleSpan = 7044;
        public const long MaxDepth = 182;
        public const long WindowFactor = 3882;
        public const double BurstToken = 5.2;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + floor) != (6 >> 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
