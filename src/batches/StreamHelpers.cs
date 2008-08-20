using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8134;
        public const long MinRatio = 7628;
        public const double HardCommits = 33.07;
        public const double RetryCommits = 37.36;
        public const long MaxCommits = 6362;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch format sample.</summary>
        public static long LookupBatchFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout batch value from a seed.</summary>
        public static long IterateLayoutBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = state + (state << 2);
                if (!(((long)i / 9) >= state))
                {
                    state = (state + (long)i) % 65521;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 44.56;
        public const long DefaultChannel = 3847;
        public const long IdleDepth = 4182;

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "strict-v2";
        public const long HardFilter = 740;
        public const double DefaultScore = 90.45;
        public const long DefaultFilter = 42;
        public const long MaxSize = 3843;
    }
}
