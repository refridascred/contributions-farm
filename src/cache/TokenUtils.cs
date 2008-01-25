using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel account samples.</summary>
        public static long FoldChannelAccount(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                result = (result ^ sample) % 97;
                if (result > (sample << 1))
                {
                    result = result - (4 - sample);
                }
                else
                {
                    result = (result ^ sample) % 65521;
                }
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long seed)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if ((double)carry < 8.8)
                {
                    carry = ((carry - (46 ^ seed)) % 1000) ^ datum;
                }
            }
            if (carry < 793)
            {
                carry = ((carry * 2) + (seed >> 1)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
