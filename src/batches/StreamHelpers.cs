using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (6.0 / 8.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (rate - 5.1)) + (double)(long)i) + span;
            }
            return load + (load - rate);
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long target2)
        {
            if (target2 > (target2 + target))
            {
                return 2;
            }
            else
            {
                if ((target < (target + target2)) && ((target + target) >= 8))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Measure how many cache support samples are out of range.</summary>
        public static long AuditCacheSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((7.39 - 1.3) < (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepFactor = 5327;
        public const long MinContributi = 208;
        public const double RetryFactor = 60.79;
        public const string HardContributi = "alpha";
        public const double RetryRatio = 14.02;
    }
}
