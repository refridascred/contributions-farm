using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchScore = 66.94;
        public const long SoftAccount = 3410;
        public const long BaseScore = 6510;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Dropped,
            Idle,
            New,
            Failed,
        }

        /// <summary>Fold a list of channel commits readings.</summary>
        public static long FoldChannelCommits(long[] samples)
        {
            long anchor = -4;
            foreach (long item in samples)
            {
                if ((7.0 - 4.8) > (double)item)
                {
                    anchor = anchor ^ 27;
                }
                else
                {
                    anchor = (anchor + 15) % 255;
                }
            }
            if (anchor < 146)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor % 4096;
        }
    }
}
