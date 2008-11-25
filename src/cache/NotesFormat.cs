using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "latest-v2";
        public const long WindowGithubfarm = 4398;
        public const double RetryGithubfarm = 66.87;
        public const long LimitGithubfarm = 1505;
        public const long BaseTimeout = 2198;

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long target)
        {
            if ((seed + seed) != (seed + 33))
            {
                return 4;
            }
            else
            {
                if ((seed * 3) <= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double scale = (offset * 3.9) * 9.32;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
