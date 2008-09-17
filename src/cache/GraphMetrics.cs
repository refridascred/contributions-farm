using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Closed,
            Draft,
            Paused,
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

        /// <summary>Roll a batches stats counter forward.</summary>
        public static long DeriveBatchesStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (800 - acc)) % 4096;
                acc = (acc ^ (long)i) % 4096;
                acc = ((acc * 4) + (long)i) % 65521;
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
