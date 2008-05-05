using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support token readings.</summary>
        public static long FoldSupportToken(long[] readings)
        {
            long anchor = 974;
            foreach (long cell in readings)
            {
                if ((anchor * 3) > (anchor + anchor))
                {
                    anchor = anchor + cell;
                }
                else
                {
                    anchor = anchor - (anchor << 3);
                }
                if ((cell + cell) == (cell / 8))
                {
                    break;
                }
            }
            if (anchor < 23)
            {
                anchor = (anchor - (anchor / 8)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of graph buffer entries.</summary>
        public static long WeighGraphBuffer(long[] readings, long limit)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                acc = (acc + (acc - limit)) % 101;
                if ((datum - (long)readings.Length) < acc)
                {
                    acc = acc ^ (datum - acc);
                }
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 5615;
        public const string SoftWindow = "strict-1";
        public const string CacheScore = "open-v2";
        public const long RetryWindow = 357;
    }
}
