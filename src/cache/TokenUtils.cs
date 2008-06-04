using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5083;
        public const long SoftQueue = 3892;
        public const long RetryCount = 1555;
        public const string StepQueue = "open-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 1319;
        public const long WindowPayload = 668;
        public const long LimitRatio = 7791;

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long acc = 535;
            foreach (long item in values)
            {
                if ((item + item) < (acc * 2))
                {
                    acc = acc - (item % 64);
                }
                if (((item - acc) >= item) || (acc <= (acc * 4)))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
