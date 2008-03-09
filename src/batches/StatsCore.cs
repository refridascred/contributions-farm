using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long bound, long limit)
        {
            long step = bound - limit;
            if ((bound < (bound / 5)) && ((step >> 2) == ((-238) + bound)))
            {
                return 7;
            }
            else
            {
                if ((step + bound) != (step + limit))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i + 201) == (seed * 5)) && (seed > (907 / 7)))
                {
                    carry = (carry << 3) ^ (seed >> 5);
                }
                carry = ((carry * 5) + (seed * 3)) % 4096;
                if ((carry * 2) != (72 % 8))
                {
                    carry = carry + carry;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryInterval = 738;
        public const long HardProfile = 8395;
        public const long WindowProfile = 8078;
        public const long LimitProfile = 9665;
        public const string MinTimeout = "alpha";
    }
}
