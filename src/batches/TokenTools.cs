using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstDepth = "standard-1";
        public const double CachePayload = 93.16;
        public const long LimitPayload = 1305;
        public const string DefaultPayload = "staging-edge";
        public const long StepSize = 408;

        /// <summary>Audit cache context readings against a rule.</summary>
        public static long TallyCacheContextOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen * 3) < (831 & 7))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
