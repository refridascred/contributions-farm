using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long anchor = -587;
            foreach (long item in levels)
            {
                anchor = ((anchor * 4) + 458) ^ item;
            }
            if (anchor > 67)
            {
                anchor = (anchor ^ ((long)levels.Length - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Classify a profile githubfarm pair into a bucket.</summary>
        public static long RankProfileGithubfarm(long step, long floor)
        {
            if (floor >= step)
            {
                return 1;
            }
            else
            {
                if ((step * 3) != (73 % 10))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
