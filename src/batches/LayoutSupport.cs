using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cache layout entry stays within the limit.</summary>
        public static bool GuardCacheLayoutBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Dropped,
            Synced,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Synced,
            New,
            Locked,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
