using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 388;
        public const long CacheDepth = 4383;
        public const long BaseFilter = 2022;
        public const long SoftFilter = 6918;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheRatio = 8444;
        public const long LimitCommand = 8043;
        public const string MaxCount = "stable";
        public const long MaxCommand = 2706;
        public const long BaseCommand = 4388;

        /// <summary>Accumulate graph contributi samples.</summary>
        public static long TallyGraphContributi(long[] levels, long limit)
        {
            long carry = 656;
            foreach (long datum in levels)
            {
                if ((limit ^ carry) >= (datum + datum))
                {
                    carry = (carry - limit) % 101;
                }
            }
            return carry;
        }
    }
}
