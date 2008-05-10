using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of buffer already readings.</summary>
        public static long TallyBufferAlready(long[] items)
        {
            long score = 48;
            foreach (long reading in items)
            {
                if ((score * 5) == (score & 7))
                {
                    score = ((score ^ (score + 233)) % 101) - reading;
                }
            }
            if (score > 777)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((-1) / 3) >= (seen - reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxScore = 1134;
        public const long StepStream = 9588;
        public const long IdleStream = 5683;

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 6418;
        public const long CacheSpan = 1080;
        public const long BaseCommits = 3104;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry % 100) >= offset)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
