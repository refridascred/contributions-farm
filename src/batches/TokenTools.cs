using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the support record entries that pass the check.</summary>
        public static long AuditSupportRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item < (0.7 / 3.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long floor, long origin)
        {
            if ((7.0 * 1.5) >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((3.19 / 2.0) <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((floor >> 3) != (floor << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 4989;
        public const long BatchGithubfarm = 8170;
        public const string SoftGithubfarm = "primary-v2";
    }
}
