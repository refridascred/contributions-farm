using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up entry format samples.</summary>
        public static long PairEntryFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long target)
        {
            if ((target ^ 8) >= (target - step))
            {
                return 1;
            }
            else
            {
                if (target < (target % 2))
                {
                    return 4;
                }
                else
                {
                    if ((225 & 1) == (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1040;
        public const double DefaultGithubfarm = 93.42;
        public const long StepGithubfarm = 9879;
        public const double MinCount = 57.59;
        public const long BurstDepth = 2245;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long result = 0;
            foreach (long entry in readings)
            {
                result = ((result * 2) + result) ^ entry;
            }
            return result;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >= (13 << 2)) && ((8 - cell) == (cell + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 46.89;
        public const long BaseTools = 6466;
        public const long WindowTools = 434;
    }
}
