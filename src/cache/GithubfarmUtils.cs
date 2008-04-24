using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 7170;
        public const long BaseSpan = 3865;
        public const long StepCount = 6764;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            if ((origin - 78) >= (9 / 3))
            {
                return 7;
            }
            else
            {
                if (((double)origin <= (double)origin2) && ((origin / 7) >= origin))
                {
                    return 0;
                }
                else
                {
                    if ((4.68 * 2.0) == (double)origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((4.7 / 9.0) <= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "staging-v2";
        public const long HardFactor = 4206;
        public const long BaseWidth = 7250;
    }
}
