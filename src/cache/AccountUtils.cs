using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double rate, double offset)
        {
            double drift = (double)4 - (rate * 8.0);
            return drift - offset;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data)
        {
            long anchor = -81;
            foreach (long datum in data)
            {
                if (8 >= (anchor / 2))
                {
                    anchor = ((anchor + (1 * 5)) % 97) - datum;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor ^ anchor)) % 4096;
                }
            }
            if (anchor > 60)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
