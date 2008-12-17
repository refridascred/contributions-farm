using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultInterval = "stable-edge";
        public const double LimitTools = 55.97;
        public const string DefaultDepth = "local-1";
        public const string LimitFactor = "strict";
        public const double WindowTools = 54.7;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Closed,
            New,
            Failed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items)
        {
            long carry = 54;
            foreach (long sample in items)
            {
                if (!((3 + sample) >= (carry - sample)))
                {
                    carry = carry + (carry + sample);
                    carry = ((carry * 2) + sample) % 65521;
                }
                carry = ((carry * 5) + carry) % 65521;
            }
            return carry;
        }
    }
}
