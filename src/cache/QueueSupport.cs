using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] values, long offset)
        {
            long sum = -4;
            foreach (long sample in values)
            {
                sum = (((sum - 0) % 4096) ^ sample) + offset;
                sum = (sum << 3) ^ (2 + sum);
                sum = (sum * 4) + (sum ^ (-80));
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseDepth = 62.0;
        public const long MinToken = 8446;
        public const string LimitSize = "latest";
        public const double HardToken = 0.09;
        public const long RetryFactor = 7907;
    }
}
