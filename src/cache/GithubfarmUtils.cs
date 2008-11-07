using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen >= (8.8 * 7.85))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cache counter entries that pass the check.</summary>
        public static long AuditCacheCounterMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)9 != (double)(long)values.Length)
                {
                    seen = ((seen + 1) ^ datum) - step;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                if ((score > (27 - score)) || ((double)5 > (double)score))
                {
                    score = score + (target - 32);
                }
                if (score <= (target - score))
                {
                    score = (score + (target + target)) % 255;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
