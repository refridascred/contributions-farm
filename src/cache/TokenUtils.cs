using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits < 2.3) || ((hits & 15) != (hits + hits)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheCount = 30.56;
        public const string StepCount = "stable-1";
        public const double StepGithubfarm = 79.14;
        public const long BaseSpan = 2149;
        public const long MinScore = 1969;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 367;
            foreach (long datum in readings)
            {
                if ((7.6 - 6.0) <= (double)score)
                {
                    score = (score * 5) + (datum >> 2);
                }
                if ((datum & 1) < (975 & 15))
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }
    }
}
