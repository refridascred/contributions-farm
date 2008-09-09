using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long limit)
        {
            long delta = seed + limit;
            if (((seed - limit) <= seed) && ((7.0 + 9.6) <= (double)seed))
            {
                return 2;
            }
            else
            {
                if (((171 << 2) <= delta) || ((delta - 50) <= 88))
                {
                    return 5;
                }
                else
                {
                    if (((seed + limit) > seed) && ((limit + seed) >= (limit / 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
