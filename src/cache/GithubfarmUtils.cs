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

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] series)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if (anchor >= value)
                {
                    anchor = (anchor + ((long)series.Length & 127)) % 101;
                }
            }
            if (anchor < 348)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 63.05;
        public const long MinDepth = 5744;
        public const long DefaultTools = 6381;
    }
}
