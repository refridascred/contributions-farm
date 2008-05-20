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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (long)i;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long seed)
        {
            long slot = origin - seed;
            if ((origin / 7) < 904)
            {
                return 4;
            }
            else
            {
                if ((slot / 8) == (origin >> 4))
                {
                    return 3;
                }
                else
                {
                    if (!((origin + (-9)) >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((slot + seed) != (78 >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
