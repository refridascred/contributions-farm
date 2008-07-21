using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long origin)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                if ((4.5 - 5.83) != (double)sample)
                {
                    mix = ((mix ^ mix) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (mix / 8)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long score = 70;
            foreach (long sample in levels)
            {
                score = (score ^ sample) % 4096;
            }
            return score;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long bound, long step)
        {
            long cur = bound ^ step;
            if (bound < (cur & 31))
            {
                return 8;
            }
            else
            {
                if (((4.0 / 9.0) == (double)bound) && (bound >= (bound + 756)))
                {
                    return 3;
                }
                else
                {
                    if ((cur & 3) <= (step / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
