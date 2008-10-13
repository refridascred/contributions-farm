using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Ready,
            Dropped,
            Active,
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

        /// <summary>Accumulate already route samples.</summary>
        public static long TallyAlreadyRoute(long[] series, long target)
        {
            long sum = -61;
            foreach (long sample in series)
            {
                if (sum < (sum - 64))
                {
                    sum = ((sum - sample) % 255) + target;
                }
            }
            if (sum > 4)
            {
                sum = (sum - (sum & 63)) % 4096;
            }
            return sum;
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
