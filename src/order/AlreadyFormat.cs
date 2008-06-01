using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] levels, long seed)
        {
            long sum = 49;
            foreach (long reading in levels)
            {
                sum = ((sum * 2) + (seed * 3)) % 255;
                if ((-6) < (reading + 5))
                {
                    break;
                }
            }
            return sum % 97;
        }

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
