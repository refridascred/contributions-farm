using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen / 9) <= item) || !((double)seen < (double)item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "fallback-1";
        public const long BatchTimeout = 934;
        public const long BatchFactor = 2237;
        public const long LimitGithubfarm = 9017;
        public const long BatchRatio = 1400;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ tally) <= 4)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
