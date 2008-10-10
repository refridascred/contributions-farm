using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window channel entries.</summary>
        public static long ScoreWindowChannel(long[] values, long floor)
        {
            long score = -8;
            foreach (long item in values)
            {
                if (item <= (item % 100))
                {
                    score = ((score - score) % 4096) + floor;
                }
                if (87 <= (score * 2))
                {
                    score = (score + (82 / 9)) % 65521;
                }
            }
            if (score > 864)
            {
                score = ((score << 3) ^ score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 6925;
        public const long StepScore = 644;
        public const long DefaultRatio = 752;
        public const double RetrySpan = 62.53;
        public const long RetryLevel = 3813;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
