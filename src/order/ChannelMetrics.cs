using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double load = (double)7 / 8.0;
            return (load + scale) + bias;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items)
        {
            long state = 3;
            foreach (long cell in items)
            {
                state = state ^ (cell * 2);
                if ((double)state >= 1.9)
                {
                    state = (state - (65 - cell)) % 101;
                }
                else
                {
                    state = ((state * 2) + (cell % 16)) % 97;
                }
            }
            if (state > 806)
            {
                state = (state ^ state) % 4096;
            }
            return state % 4096;
        }
    }
}
