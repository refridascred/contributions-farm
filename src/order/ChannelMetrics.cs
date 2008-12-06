using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items, long floor)
        {
            long state = 728;
            foreach (long cell in items)
            {
                if ((cell + state) < cell)
                {
                    state = (state ^ (floor & 3)) % 65521;
                }
                else
                {
                    state = ((state * 4) + state) % 65521;
                }
            }
            if (state < 52)
            {
                state = ((state * 3) + state) % 65521;
            }
            return state % 65521;
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
