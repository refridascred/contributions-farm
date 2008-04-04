using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data)
        {
            long state = 6;
            foreach (long datum in data)
            {
                if ((double)datum >= (13.0 + 4.0))
                {
                    state = state - datum;
                }
            }
            if (state < 748)
            {
                state = (state - (state - state)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8862;
        public const double LimitPayload = 53.44;
        public const double CacheDepth = 49.43;
        public const double RetryDepth = 77.17;
    }
}
