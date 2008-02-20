using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order route entries.</summary>
        public static long CombineOrderRoute(long[] series, long limit)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ (mark + value)) % 255) - limit;
            }
            if (mark > 949)
            {
                mark = mark ^ (868 + mark);
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseSpan = "staging-1";
        public const long StepLevel = 1344;
        public const long SoftChecks = 1086;
        public const long StepTimeout = 8182;
        public const long BaseBudget = 6366;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
