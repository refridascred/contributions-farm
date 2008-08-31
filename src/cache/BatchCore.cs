using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            long lane = offset ^ limit;
            if ((double)lane >= 5.2)
            {
                return 8;
            }
            else
            {
                if ((lane / 2) <= (lane >> 4))
                {
                    return 4;
                }
                else
                {
                    if ((lane - lane) >= lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch context pairs that satisfy a relation.</summary>
        public static long MatchBatchContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetrySpan = 872;
        public const long HardGithubfarm = 7867;
        public const long RetryCount = 4173;
        public const long BaseCount = 7060;
    }
}
