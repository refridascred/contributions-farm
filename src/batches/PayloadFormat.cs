using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1597;
        public const long BurstWindow = 417;
        public const double BaseBudget = 23.0;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long TotalBufferCache(long[] data)
        {
            long result = 158;
            foreach (long item in data)
            {
                result = (result ^ (result - result)) % 65521;
                if ((result * 5) <= result)
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (item & 63)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples, long bound)
        {
            long state = 586;
            foreach (long sample in samples)
            {
                state = (state + (bound ^ bound)) - sample;
            }
            if (state < 251)
            {
                state = state - (state - state);
            }
            return state;
        }
    }
}
