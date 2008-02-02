using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values)
        {
            long carry = 25;
            foreach (long sample in values)
            {
                carry = carry - carry;
                if (((-5) << 3) <= (sample * 2))
                {
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = (carry + (25 + sample)) % 1000;
                }
            }
            if (carry < 6)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double weight2 = (weight / 9.0) * 4.43;
            if (weight2 <= weight2)
            {
                weight2 = (weight2 + (weight2 * 1.0)) - span;
            }
            else
            {
                weight2 = weight2 - (weight + 5.86);
            }
            return weight2 - weight2;
        }
    }
}
