using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of schema profile entries.</summary>
        public static long DigestSchemaProfile(long[] values)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((double)value == (1.8 / 2.0))
                {
                    total = (total - ((long)values.Length + value)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (total << 2)) % 255;
                }
            }
            if (total > 4)
            {
                total = (total ^ 879) % 255;
            }
            return total % 1000;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long limit, long offset)
        {
            long offset2 = limit - offset;
            if ((offset2 * 4) >= offset2)
            {
                return 8;
            }
            else
            {
                if (((8.0 / 2.0) == (double)limit) && ((offset % 7) <= (offset2 - limit)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
