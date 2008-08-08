using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardFactor = 5547;
        public const string CacheCount = "fallback-1";
        public const long BaseSize = 1413;
        public const long SoftInterval = 8889;
        public const long BaseTimeout = 8618;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ (total / 3)) % 255) + (long)i2;
                }
                total = ((total << 3) ^ ((long)i >> 5)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long target)
        {
            long delta = floor + target;
            if ((double)delta < (7.0 + 1.0))
            {
                return 4;
            }
            else
            {
                if (target < (target + delta))
                {
                    return 5;
                }
                else
                {
                    if (target < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum * 3) + (sum - limit);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
