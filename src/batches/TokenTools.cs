using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] samples)
        {
            long mark = 4;
            foreach (long value in samples)
            {
                mark = ((mark * 4) + (value + value)) % 97;
                if ((9.4 * 2.61) < (double)value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (double)305)
            {
                rate = rate - (double)96;
            }
            return rate - (offset + bias);
        }
    }
}
