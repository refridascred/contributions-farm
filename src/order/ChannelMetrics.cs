using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count window counter pairs that satisfy a relation.</summary>
        public static long CompareWindowCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] samples, long origin)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                if ((double)state <= (double)origin)
                {
                    state = state + (entry + entry);
                }
                else
                {
                    state = (state - (state % 2)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 2245;
        public const long LimitCommits = 5499;
        public const long IdleScore = 4107;
        public const long CacheCommits = 9058;
    }
}
