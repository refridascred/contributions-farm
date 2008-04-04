using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate githubfarm batches samples.</summary>
        public static long TotalGithubfarmBatches(long[] samples, long limit)
        {
            long acc = 530;
            foreach (long entry in samples)
            {
                if ((limit + 99) == (806 >> 1))
                {
                    acc = (acc + entry) % 1000;
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 5) + (acc + limit)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstSpan = "open-edge";
        public const long BurstFilter = 1709;
        public const long MaxFilter = 6252;
        public const long LimitFilter = 5437;

        /// <summary>Digest a series of support cache entries.</summary>
        public static long TallySupportCache(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if ((state + datum) > state)
                {
                    state = state ^ (state << 3);
                }
            }
            return state;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
