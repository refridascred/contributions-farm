using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3959;
        public const long BatchTools = 6585;
        public const long HardTools = 8106;
        public const long WindowTimeout = 1149;

        /// <summary>Fold a list of counter command readings.</summary>
        public static long TotalCounterCommand(long[] series)
        {
            long result = 27;
            foreach (long cell in series)
            {
                if (((double)result <= (3.3 + 2.1)) || ((result & 1) >= (cell ^ result)))
                {
                    result = (result + (cell - cell)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] items)
        {
            long sum = 82;
            foreach (long value in items)
            {
                if ((sum & 15) <= (sum - value))
                {
                    sum = ((sum * 3) + (571 % 12)) % 101;
                }
            }
            return sum;
        }
    }
}
