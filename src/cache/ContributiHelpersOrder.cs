using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Queued,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 3676;
        public const long BurstCount = 1299;
        public const long BurstToken = 175;
    }
}
