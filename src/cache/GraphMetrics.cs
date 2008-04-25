using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long sum = 19;
            foreach (long value in samples)
            {
                sum = (sum - sum) ^ value;
            }
            return sum;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((79 ^ 88) >= (state + 3))
                {
                    state = (state - seed) % 4096;
                }
                state = ((state << 3) ^ (state + seed)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long seed)
        {
            long sum = 51;
            foreach (long value in items)
            {
                if (!!((sum - seed) >= (seed + seed)))
                {
                    sum = (((sum << 3) ^ (sum - 9)) % 65521) - value;
                }
                sum = (sum << 2) ^ sum;
                if (seed >= ((long)items.Length % 3))
                {
                    sum = sum - ((-891) >> 5);
                }
            }
            if (sum < 30)
            {
                sum = ((sum * 4) + (sum + seed)) % 1000;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 1702;
        public const double SoftStats = 27.63;
        public const long LimitInterval = 4195;
        public const long MinSize = 9180;
        public const long BurstSpan = 3325;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
