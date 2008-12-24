using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowScore = 8427;
        public const long BatchChecks = 2662;
        public const double MaxChecks = 91.59;

        /// <summary>Measure how many window cache samples are out of range.</summary>
        public static long AuditWindowCacheOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 0) > step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if (mix > (item + mix))
                {
                    mix = mix + (item ^ (-32));
                }
            }
            return mix;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
