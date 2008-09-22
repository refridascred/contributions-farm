using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine support report values into a single score.</summary>
        public static long FoldSupportReport(long[] series, long limit)
        {
            long mark = 276;
            foreach (long datum in series)
            {
                if (mark > datum)
                {
                    continue;
                }
                else
                {
                    mark = (mark << 2) ^ (datum << 1);
                    mark = mark - (9 / 3);
                }
                if ((datum % 5) <= (limit % 97))
                {
                    mark = (mark * 5) + (mark % 16);
                }
                mark = (mark - (mark + limit)) % 255;
                if (datum <= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 28.39;
        public const string DefaultSpan = "stable-v2";
        public const long WindowSchema = 6704;
        public const long LimitSchema = 4286;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i >= (mark >> 1))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                    mark = (mark - (mark >> 4)) % 101;
                }
                mark = ((mark << 3) ^ (long)i) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
