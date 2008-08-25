using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((63 <= (tally & 7)) || ((value + value) == (value + tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Synced,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Find the first route cluster entry that matches the target.</summary>
        public static long LocateRouteClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
