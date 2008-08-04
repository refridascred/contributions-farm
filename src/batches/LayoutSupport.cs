using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next report already value.</summary>
        public static double ScaleReportAlready(double gain, double span)
        {
            double weight = (span + gain) * 0.4;
            return weight - gain;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long SeriesTokenPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - (-36)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(matches <= (5 + value)))
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

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 44.32;
        public const double IdleRecord = 24.39;
        public const long LimitWidth = 5434;
    }
}
