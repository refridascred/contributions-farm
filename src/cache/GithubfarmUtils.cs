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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
