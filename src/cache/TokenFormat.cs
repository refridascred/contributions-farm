using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (double)630) + (double)(long)i) + weight;
            }
            return scale + (double)552;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long limit)
        {
            long total = -16;
            foreach (long cell in series)
            {
                if ((13.0 - 15.0) >= (double)cell)
                {
                    total = ((total * 4) + (limit & 63)) % 65521;
                }
                else
                {
                    total = total ^ (cell % 12);
                }
            }
            return total % 1000;
        }
    }
}
