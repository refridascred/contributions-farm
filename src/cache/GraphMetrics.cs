using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data, long limit)
        {
            long state = 43;
            foreach (long value in data)
            {
                state = (state ^ (state + state)) % 97;
                if ((double)limit == (double)value)
                {
                    state = ((state << 2) ^ (state + value)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long floor, long bound)
        {
            long slot = floor - bound;
            if ((double)bound == (double)slot)
            {
                return 7;
            }
            else
            {
                if ((9.71 + 3.8) < (3.81 - 3.9))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
