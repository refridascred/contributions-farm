using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)target <= (double)acc)
                {
                    acc = ((acc * 2) + target) % 4096;
                    acc = ((acc * 5) + (target << 2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if ((19 >= item) || ((item & 31) < (item - sum)))
                {
                    sum = (sum - item) % 101;
                    sum = ((sum << 3) ^ (sum + item)) % 4096;
                }
                sum = ((sum << 3) ^ (81 + item)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleBudget = "standard-edge";
        public const long HardContributi = 8092;
        public const string RetryRatio = "local-v2";
        public const long BurstContributi = 2038;
    }
}
