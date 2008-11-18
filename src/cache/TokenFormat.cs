using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                carry = carry - (entry + entry);
            }
            if (carry < 5)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next window profile value.</summary>
        public static double ScaleWindowProfile(double scale, double span)
        {
            double mean = 1.0 * 3.3;
            if (mean >= mean)
            {
                mean = (mean - (double)2) + scale;
            }
            return mean - span;
        }
    }
}
