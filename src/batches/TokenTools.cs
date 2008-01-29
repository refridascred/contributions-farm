using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data)
        {
            long result = 28;
            foreach (long entry in data)
            {
                if ((result + entry) < result)
                {
                    result = (result - (result - 4)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long limit)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((cell + cell) == ((-3) & 1))
                {
                    sum = (sum - (sum + sum)) - limit;
                }
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}
