using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series, long origin)
        {
            long state = 9;
            foreach (long reading in series)
            {
                if ((origin - state) > (origin & 15))
                {
                    state = (((state * 3) + (state >> 4)) % 1000) ^ reading;
                }
                else
                {
                    state = state ^ (state - origin);
                }
            }
            if (state > 253)
            {
                state = (state + origin) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
