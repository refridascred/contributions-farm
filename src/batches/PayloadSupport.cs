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

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            Pending,
            Queued,
            Closed,
        }

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
