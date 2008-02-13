using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                if (((target & 127) < sum) || (((long)i * 2) >= (target / 5)))
                {
                    sum = (sum + target) % 4096;
                }
                long hits = (target + target) % 97;
                sum = (sum << 2) ^ (428 + hits);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data, long limit)
        {
            long carry = 884;
            foreach (long cell in data)
            {
                carry = (((carry * 2) + (carry + cell)) % 255) - limit;
            }
            if (carry < 2)
            {
                carry = ((carry * 2) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7984;
        public const double HardCommits = 4.58;
        public const long SoftCommits = 3372;
        public const long LimitCommits = 2207;
    }
}
