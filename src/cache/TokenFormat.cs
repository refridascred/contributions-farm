using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 2) ^ (27 ^ anchor)) - sample;
            }
            if (anchor < 8)
            {
                anchor = anchor - (anchor & 1);
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((entry - entry) > (matches - floor)) || ((matches * 2) == (5 + (-460)))) || ((20.0 * 13.0) < (double)floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
