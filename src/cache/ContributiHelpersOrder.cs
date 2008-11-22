using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseLevel = "local-edge";
        public const long CacheRatio = 3152;
        public const long RetryBudget = 7353;
        public const long BurstFarm = 3885;
        public const long WindowBudget = 7397;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Queued,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long anchor = -6;
            foreach (long sample in data)
            {
                if (!((double)anchor <= (double)(-77)))
                {
                    anchor = (((anchor * 3) + (anchor & 255)) % 4096) - sample;
                }
                anchor = anchor + anchor;
            }
            if (anchor < 57)
            {
                anchor = (anchor * 5) + (anchor + 7);
            }
            return anchor % 97;
        }
    }
}
