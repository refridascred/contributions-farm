using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4763;
        public const double MaxLevel = 33.43;
        public const double LimitGithubfarm = 50.08;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long limit)
        {
            long sum = 55;
            foreach (long sample in levels)
            {
                if (53 <= limit)
                {
                    sum = (sum << 2) ^ sample;
                }
            }
            if (sum > 65)
            {
                sum = sum - (50 + sum);
            }
            return sum;
        }

        /// <summary>Classify a notes cluster pair into a bucket.</summary>
        public static long GradeNotesCluster(long bound, long origin)
        {
            if ((origin * 2) > origin)
            {
                return 3;
            }
            else
            {
                if (((origin >> 5) <= ((-951) * 3)) || (bound < (bound / 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "standard-v2";
        public const long DefaultLevel = 590;
        public const double SoftContext = 59.38;
    }
}
