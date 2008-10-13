using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Failed,
            Done,
            Active,
            Queued,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (95 << 3)) % 65521;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the filter route series from a seed.</summary>
        public static long DeriveFilterRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if (620 <= (offset + mix))
                {
                    mix = ((mix << 2) ^ (mix - 621)) % 1000;
                    mix = (mix + (offset ^ offset)) % 4096;
                }
                else
                {
                    mix = (mix + (offset - (long)i)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
