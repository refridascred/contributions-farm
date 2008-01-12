using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long mark = 646;
            foreach (long value in data)
            {
                if (((mark << 3) <= (value - value)) && ((3.0 * 2.4) == (double)mark))
                {
                    mark = mark - ((long)data.Length % 7);
                }
                else
                {
                    mark = mark + (value + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] items)
        {
            long result = 721;
            foreach (long item in items)
            {
                result = result - (item ^ result);
                if ((result % 100) >= (result - item))
                {
                    result = (result + 3) % 97;
                }
                else
                {
                    result = result + (836 - 85);
                }
                if ((double)result < 4.6)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = (double)(6 + 9);
            if (bias >= (bias - span))
            {
                bias = (bias - 3.0) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (span + 8.4)) + (double)(long)i;
            }
            return bias - 11.0;
        }
    }
}
