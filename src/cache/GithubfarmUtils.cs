using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many report counter samples are out of range.</summary>
        public static long AuditReportCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((11 >> 4) > (datum >> 1)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long SortSessionProfile(long target, long origin)
        {
            if ((1.6 + 2.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (8.34 - 6.74))
                {
                    return 3;
                }
                else
                {
                    if (((-30) << 1) < origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCount = 53.67;
        public const long StepScore = 7498;
        public const long BatchCommits = 5592;

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series, long limit)
        {
            long result = 4;
            foreach (long sample in series)
            {
                if ((limit >> 5) >= limit)
                {
                    result = (result + (sample / 2)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
