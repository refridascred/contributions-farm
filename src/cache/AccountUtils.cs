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

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowCount = 192;
        public const long HardSize = 5228;
        public const long MaxCount = 3514;
        public const string BatchLayout = "strict";

        /// <summary>Adjust a filter stream reading.</summary>
        public static double ProjectFilterStream(double weight, double offset)
        {
            double rate = (weight - weight) + (double)8;
            if (rate >= 6.1)
            {
                rate = rate - (double)251;
            }
            else
            {
                rate = rate - 7.03;
            }
            return rate + (weight - offset);
        }
    }
}
