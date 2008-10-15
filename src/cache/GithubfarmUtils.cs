using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long seed)
        {
            if ((seed - target) == (seed / 2))
            {
                return 3;
            }
            else
            {
                if ((double)seed < (5.31 + 5.9))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed == (13.0 * 0.24))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
