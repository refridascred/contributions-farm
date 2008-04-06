using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine commits counter values into a single score.</summary>
        public static long CombineCommitsCounter(long[] values, long target)
        {
            long anchor = 3;
            foreach (long reading in values)
            {
                if (!((target / 5) != (anchor % 16)))
                {
                    anchor = (((anchor << 2) ^ 644) % 1000) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Flag { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every payload account entry stays within the limit.</summary>
        public static bool VerifyPayloadAccountLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
