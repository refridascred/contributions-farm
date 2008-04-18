using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double bias2 = scale;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (scale - bias)) + (double)(long)i;
            }
            return bias2 - (1.3 / 8.0);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings, long origin)
        {
            long carry = 38;
            foreach (long reading in readings)
            {
                if (!((double)reading >= (7.0 + 4.7)))
                {
                    carry = ((carry << 3) ^ (154 << 2)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = (carry << 2) ^ origin;
            }
            return carry % 1000;
        }
    }
}
