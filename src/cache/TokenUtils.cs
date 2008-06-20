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

        /// <summary>Roll a filter batch counter forward.</summary>
        public static long SeriesFilterBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
