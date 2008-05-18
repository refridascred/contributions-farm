using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank channel cache input into a small class.</summary>
        public static long SortChannelCache(long limit, long step)
        {
            if ((step / 8) > (limit % 16))
            {
                return 2;
            }
            else
            {
                if ((5 << 3) != (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long TotalEditorGithubfarm(long[] levels)
        {
            long score = 68;
            foreach (long reading in levels)
            {
                if (8.8 < (9.91 * 4.61))
                {
                    score = (score ^ reading) % 255;
                }
            }
            if (score < 680)
            {
                score = score - 46;
            }
            return score % 4096;
        }
    }
}
