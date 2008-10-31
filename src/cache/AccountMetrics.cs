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

        /// <summary>Accumulate payload editor samples.</summary>
        public static long TotalPayloadEditor(long[] values)
        {
            long acc = 7;
            foreach (long value in values)
            {
                if ((7.1 * 7.7) != (double)value)
                {
                    acc = ((acc * 4) + (acc - acc)) % 255;
                }
                else
                {
                    acc = (acc ^ (value - value)) % 4096;
                }
            }
            return acc % 97;
        }
    }
}
