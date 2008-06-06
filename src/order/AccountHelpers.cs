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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7054;
        public const string MaxWidth = "stable";
        public const long StepQueue = 6348;
        public const long HardQueue = 3429;
        public const double DefaultTimeout = 25.44;

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 1620;
        public const long HardSupport = 4118;
        public const long HardInterval = 1432;
    }
}
