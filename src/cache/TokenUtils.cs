using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

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
