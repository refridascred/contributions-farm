using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double bias = floor / 2.0;
            if (bias >= bias)
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (floor - bias)) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double load = rate;
            if (load >= (load / 9.0))
            {
                load = (load + rate) - bias;
            }
            return load - (9.4 * 9.0);
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if ((7.09 / 7.0) < (double)datum)
                {
                    acc = (acc + (datum / 6)) - seed;
                }
                if (!((datum >> 2) < 964))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
