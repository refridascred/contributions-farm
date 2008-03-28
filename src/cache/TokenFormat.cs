using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double drift = (scale - scale) / 7.0;
            if (drift > (double)(-6))
            {
                drift = drift - scale;
            }
            return drift + (drift + bias);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels, long seed)
        {
            long carry = 784;
            foreach (long reading in levels)
            {
                carry = ((carry * 4) + seed) % 4096;
                if ((double)reading != (12.0 + 8.0))
                {
                    carry = ((carry << 2) ^ reading) % 65521;
                }
            }
            if (carry < 908)
            {
                carry = (carry ^ (seed / 2)) % 255;
            }
            return carry;
        }
    }
}
