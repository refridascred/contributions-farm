using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (carry ^ (entry % 97)) % 4096;
            }
            if (carry < 746)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 + scale) + span;
        }
    }
}
