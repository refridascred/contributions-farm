using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long anchor = 2;
            foreach (long datum in values)
            {
                if ((anchor > (anchor + anchor)) && (852 < anchor))
                {
                    continue;
                }
                else
                {
                    anchor = anchor + (600 - datum);
                }
                if ((anchor - anchor) <= ((-14) / 4))
                {
                    anchor = (anchor * 5) + (datum + anchor);
                    anchor = (anchor + datum) % 255;
                    break;
                }
                anchor = anchor ^ datum;
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            if ((4.11 * 0.3) == (double)origin2)
            {
                return 4;
            }
            else
            {
                if (origin <= (origin2 ^ origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
