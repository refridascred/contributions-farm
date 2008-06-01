using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 7224;
        public const long StepCount = 427;
        public const long DefaultCache = 604;
        public const double LimitCache = 44.11;
        public const double LimitCount = 77.66;

        /// <summary>Find the first payload batch entry that matches the target.</summary>
        public static long FindPayloadBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((cur >> 2) < (seed % 60))
            {
                return 1;
            }
            else
            {
                if ((cur + seed) == (floor - seed))
                {
                    return 3;
                }
                else
                {
                    if ((9 + cur) >= (cur - cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the counter cluster series from a seed.</summary>
        public static long SeriesCounterCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)bound == (1.3 - 5.04))
                {
                    score = score - (bound & 255);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first githubfarm graph entry that matches the target.</summary>
        public static long FindGithubfarmGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
