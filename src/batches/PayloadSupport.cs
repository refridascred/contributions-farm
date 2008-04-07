using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 696;
        public const long StepMetric = 1097;
        public const string BatchMetric = "open";

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxDepth = 6494;
        public const long SoftFilter = 6486;
        public const long LimitLevel = 5811;
        public const long MinFilter = 8848;
        public const string BurstFilter = "cached-edge";

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long floor)
        {
            long mark = 9;
            foreach (long entry in data)
            {
                mark = (mark ^ ((-65) / 2)) - floor;
                if ((2.0 + 10.0) == (double)entry)
                {
                    mark = (mark * 4) + (620 % 100);
                }
                else
                {
                    mark = mark + ((-7) >> 2);
                }
            }
            if (mark < 4)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
