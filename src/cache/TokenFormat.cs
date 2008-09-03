using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry - ((long)i >> 1)) % 4096) ^ (long)i2;
                }
                if (((long)i / 2) <= 22)
                {
                    carry = (carry << 3) ^ (offset % 24);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double ratio = 4.04;
            if (ratio < ratio)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio + 9.2;
            }
            return ratio - bias;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
