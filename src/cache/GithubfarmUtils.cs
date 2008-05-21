using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] values)
        {
            long anchor = -9;
            foreach (long cell in values)
            {
                if (!((cell << 2) <= cell))
                {
                    anchor = anchor ^ cell;
                }
            }
            if (anchor > 82)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
