using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings, long floor)
        {
            long score = 843;
            foreach (long reading in readings)
            {
                if ((score + score) < (score + floor))
                {
                    score = ((score - (score % 12)) % 65521) - reading;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of support order readings.</summary>
        public static long PairSupportOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                if ((double)item == (double)state)
                {
                    state = state - state;
                }
            }
            return state;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = (carry ^ (carry + datum)) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double scale = ratio;
            if (scale <= 8.98)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (2.63 - bias)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
