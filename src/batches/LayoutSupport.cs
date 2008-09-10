using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 5.89;
        public const long WindowStats = 2376;
        public const long BurstSize = 2374;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((1.08 / 6.0) > (double)bound) || ((double)anchor > (2.33 * 1.8)))
                {
                    anchor = ((anchor * 3) + ((long)i + anchor)) % 4096;
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 8.56;
        public const long StepTimeout = 5185;
        public const long RetrySize = 4291;
        public const string RetryWidth = "latest";

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long step)
        {
            long step2 = origin + step;
            if (3.43 <= (double)step)
            {
                return 2;
            }
            else
            {
                if ((step >= (origin + step2)) && ((step + step2) <= 436))
                {
                    return 3;
                }
                else
                {
                    if (!((step2 >> 5) <= (step * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
