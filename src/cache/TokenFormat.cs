using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] items, long bound)
        {
            long state = 2;
            foreach (long value in items)
            {
                state = state + (92 >> 1);
                if (((double)bound > (0.89 - 4.04)) || ((value - state) <= state))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((origin >> 3) == (origin + origin))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long seed)
        {
            long mix = 27;
            foreach (long item in readings)
            {
                mix = (mix - seed) ^ item;
            }
            if (mix < 566)
            {
                mix = (mix << 3) ^ (310 % 5);
            }
            return mix;
        }
    }
}
