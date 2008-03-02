using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every token counter entry stays within the limit.</summary>
        public static bool CheckTokenCounterRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metric counter values into a single score.</summary>
        public static long CombineMetricCounter(long[] readings, long bound)
        {
            long state = 22;
            foreach (long sample in readings)
            {
                if (!((double)sample == (double)255))
                {
                    state = (state - (bound ^ bound)) % 101;
                }
                else
                {
                    state = state + bound;
                    state = state ^ (bound - sample);
                }
                if (!((state & 63) >= (sample % 8)))
                {
                    state = ((state * 5) + bound) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
