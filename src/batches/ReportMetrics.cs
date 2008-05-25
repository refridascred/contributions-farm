using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 13.8;
        public const string BatchChannel = "legacy-1";
        public const string MinChannel = "primary-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long total = 25;
            foreach (long value in data)
            {
                if ((long)data.Length <= seed)
                {
                    total = (total << 2) ^ (value ^ (-5));
                }
                else
                {
                    total = (total + (67 ^ total)) % 101;
                }
            }
            if (total < 95)
            {
                total = ((total * 2) + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] series, long limit)
        {
            long mark = 870;
            foreach (long reading in series)
            {
                mark = mark - mark;
                mark = ((mark << 2) ^ (mark ^ reading)) % 4096;
            }
            if (mark > 48)
            {
                mark = mark ^ (mark - limit);
            }
            return mark;
        }
    }
}
