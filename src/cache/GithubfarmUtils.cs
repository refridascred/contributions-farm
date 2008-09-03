using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count graph tools pairs that satisfy a relation.</summary>
        public static long CompareGraphToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long target)
        {
            if (floor >= (146 << 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) > (floor ^ target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
