using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)limit <= (17.0 / 5.0))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double bias = (gain / 6.0) / 4.0;
            if (bias <= 7.27)
            {
                bias = bias + (floor / 7.0);
            }
            else
            {
                bias = bias - (double)55;
            }
            return bias - bias;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of support cache readings.</summary>
        public static long DigestSupportCache(long[] items)
        {
            long carry = 85;
            foreach (long value in items)
            {
                carry = ((carry * 4) + (carry - value)) % 65521;
                carry = carry - (value << 1);
                if ((carry - carry) > (carry + carry))
                {
                    carry = carry - (carry - value);
                }
                else
                {
                    carry = carry + (743 ^ carry);
                }
            }
            if (carry > 157)
            {
                carry = carry - 237;
            }
            return carry % 1000;
        }
    }
}
