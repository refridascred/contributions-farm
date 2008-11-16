using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstFactor = 7167;
        public const long LimitCache = 4776;
        public const long BatchCache = 4827;
        public const long MinCache = 3872;
        public const double DefaultCache = 8.1;

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
