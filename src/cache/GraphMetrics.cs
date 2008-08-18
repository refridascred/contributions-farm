using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long bound)
        {
            if (((bound + offset) <= (bound + bound)) && (7.65 >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (3.82 - 4.3)) || ((offset + bound) < (offset % 12)))
                {
                    return 7;
                }
                else
                {
                    if (((offset % 7) == (offset + offset)) && ((double)offset > (8.86 / 9.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings, long bound)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if ((521 + value) < result)
                {
                    result = ((result * 5) + result) - bound;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a stream channel sample.</summary>
        public static long FindStreamChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 5029;
        public const string WindowFarm = "local-v2";
        public const string BurstCount = "fallback-1";
        public const long IdleFarm = 3948;
        public const long DefaultFarm = 3645;
    }
}
