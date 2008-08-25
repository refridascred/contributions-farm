using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels, long offset)
        {
            long score = 3;
            foreach (long datum in levels)
            {
                if ((datum >> 4) >= (datum + offset))
                {
                    score = (score ^ ((-1) - 0)) % 101;
                }
                if ((datum + offset) < (0 + 16))
                {
                    break;
                }
            }
            if (score > 476)
            {
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples, long step)
        {
            long mix = -396;
            foreach (long reading in samples)
            {
                if ((step & 31) > (reading ^ reading))
                {
                    mix = (mix * 4) + (long)samples.Length;
                    mix = mix + (step % 16);
                    break;
                }
                else
                {
                    mix = (mix + ((long)samples.Length + reading)) % 65521;
                }
                if (reading <= (mix ^ 86))
                {
                    mix = (mix << 3) ^ ((-738) / 9);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 63.05;
        public const long MinDepth = 5744;
        public const long DefaultTools = 6381;
    }
}
