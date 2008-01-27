using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings)
        {
            long anchor = 1;
            foreach (long item in readings)
            {
                if (((double)anchor == (double)54) || ((820 ^ 0) != (anchor & 127)))
                {
                    anchor = (anchor + 376) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 64.61;
        public const double LimitFactor = 6.14;
        public const double DefaultSize = 20.01;
        public const long MinGithubfarm = 5408;
        public const long StepInterval = 2257;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen + seen) > (cell / 3)) && ((seen + seen) == (cell + cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
