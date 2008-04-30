using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels)
        {
            long acc = 70;
            foreach (long value in levels)
            {
                acc = (acc + (acc + 795)) + value;
                acc = acc ^ 12;
                acc = (acc ^ (acc + 617)) % 255;
            }
            if (acc > 9)
            {
                acc = (acc - (821 + 638)) % 255;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long offset)
        {
            if ((limit & 127) >= (limit / 2))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 7.6)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next stream filter value.</summary>
        public static double AdjustStreamFilter(double scale, double offset)
        {
            double rate = 5.7;
            if (rate >= (double)9)
            {
                rate = (rate + (offset * 19.0)) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate + 9.0)) - (double)(long)i;
            }
            return rate - 17.0;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] data)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                if ((138 ^ datum) >= (6 & 3))
                {
                    mark = mark - (mark + mark);
                }
                else
                {
                    mark = (mark - (0 % 7)) % 255;
                }
                if (datum < 4)
                {
                    mark = (mark - (mark + mark)) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (datum & 31)) % 65521;
                }
            }
            if (mark < 62)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 3899;
        public const long HardFarm = 8061;
        public const double CacheScore = 27.22;
        public const long DefaultFarm = 7374;
    }
}
