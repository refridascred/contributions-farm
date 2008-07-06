using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool GuardFarmGraphRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((7.0 / 8.0) != (double)sample)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
