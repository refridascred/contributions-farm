using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((767 - seen) >= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Active,
            Done,
            Retry,
            Paused,
        }

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long AuditGithubfarmCounterGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((seen / 4) < bound))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((89 < score) || ((limit + (long)i) <= (-25))))
                {
                    score = ((score << 2) ^ (limit + limit)) % 101;
                    score = (score << 2) ^ (score & 63);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
