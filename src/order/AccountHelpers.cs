using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many githubfarm notes samples are out of range.</summary>
        public static long MeasureGithubfarmNotesOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + floor) == (matches + 39))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstFactor = "alpha-edge";
        public const double IdleBuffer = 3.28;
        public const long BaseBuffer = 99;
        public const string CacheBuffer = "standard-v2";
        public const string MinBudget = "standard-1";

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((7.14 / 8.0) <= (double)anchor)
                {
                    long slot = anchor;
                    anchor = (anchor - (slot % 3)) % 255;
                }
                anchor = anchor + (anchor - (long)i);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long AuditOrderReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen >= 5.8)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 1620;
        public const long HardSupport = 4118;
        public const long HardInterval = 1432;
    }
}
