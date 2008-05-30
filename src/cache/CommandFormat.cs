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

        /// <summary>Count the route editor entries that pass the check.</summary>
        public static long CountRouteEditorGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((5.4 / 2.0) < (18.0 + 17.0))
                {
                    matches = ((matches + 2) - cell) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
