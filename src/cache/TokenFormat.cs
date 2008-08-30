using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data)
        {
            long sum = 2;
            foreach (long cell in data)
            {
                if ((925 & 3) < (sum + cell))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 4) + (64 << 2)) % 97;
                }
                sum = (sum + (sum ^ sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultBudget = 7139;
        public const double IdleReport = 29.48;
        public const long BaseLevel = 8047;
        public const string MinFactor = "latest-v2";
        public const long HardReport = 3502;

        /// <summary>Roll a window batch counter forward.</summary>
        public static long IterateWindowBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (floor - total)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
