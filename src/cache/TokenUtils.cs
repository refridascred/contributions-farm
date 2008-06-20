using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchWidth = 3430;
        public const long LimitInterval = 2569;
        public const string HardInterval = "alpha-v2";
        public const long LimitScore = 6590;
        public const long SoftSpan = 7879;

        /// <summary>Look up the position of a order layout sample.</summary>
        public static long LocateOrderLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "open-edge";
        public const double MinFarm = 90.98;
        public const long MaxLevel = 2006;
        public const double MinBudget = 49.2;
    }
}
