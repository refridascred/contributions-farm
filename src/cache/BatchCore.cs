using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long state = 4;
            foreach (long entry in data)
            {
                if (((entry + state) == (state - state)) || ((state / 5) <= ((long)data.Length + state)))
                {
                    state = (state + entry) % 97;
                }
            }
            return state;
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
