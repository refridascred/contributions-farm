using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = state - (floor & 1);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first entry notes entry that matches the target.</summary>
        public static long LocateEntryNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
