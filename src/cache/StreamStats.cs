using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool GuardBufferLayoutBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long state = 9;
            foreach (long cell in samples)
            {
                if ((cell - offset) <= state)
                {
                    state = ((state * 2) + (offset + cell)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
