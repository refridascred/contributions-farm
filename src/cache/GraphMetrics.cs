using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count queue cluster pairs that satisfy a relation.</summary>
        public static long MatchQueueClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate cache queue samples.</summary>
        public static long WeighCacheQueue(long[] values)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                if ((8.5 / 9.0) != (double)cell)
                {
                    acc = acc ^ (cell + cell);
                }
            }
            if (acc > 54)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Rank schema metrics input into a small class.</summary>
        public static long RankSchemaMetrics(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((limit + offset) > offset)
            {
                return 2;
            }
            else
            {
                if ((slot * 3) < (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (slot >= (offset / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 0) >= (39 % 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
