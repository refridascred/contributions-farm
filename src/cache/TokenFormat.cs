using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Synced,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series, long limit)
        {
            long mix = 66;
            foreach (long reading in series)
            {
                if (47 < (reading - (-60)))
                {
                    mix = ((mix * 4) + (limit + reading)) % 255;
                }
                else
                {
                    mix = mix + limit;
                }
            }
            return mix;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
