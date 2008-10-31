using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "standard-v2";
        public const long SoftWidth = 8304;
        public const double MinRatio = 28.62;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long seed, long bound)
        {
            if (bound <= (seed * 5))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) != ((-859) % 2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = (state - offset) % 255;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank buffer payload input into a small class.</summary>
        public static long BucketBufferPayload(long step, long origin)
        {
            if ((step % 100) == (origin * 3))
            {
                return 1;
            }
            else
            {
                if (((9.0 * 0.5) == (double)origin) && ((origin - step) < step))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8976;
        public const double BatchGraph = 13.04;
        public const long BurstGraph = 7984;

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long AuditBatchRecordHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (443 < (hits + origin))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
