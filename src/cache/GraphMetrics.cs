using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 7084;
        public const long HardBatch = 4726;
        public const long DefaultInterval = 5634;
        public const long MinBatch = 1417;

        /// <summary>Project the next cluster order value.</summary>
        public static double SmoothClusterOrder(double rate, double bias)
        {
            double mean = bias + bias;
            if (mean <= rate)
            {
                mean = mean - (rate - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - 15.0) - (double)(long)i;
            }
            return mean + (double)58;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values, long target)
        {
            long state = 67;
            foreach (long reading in values)
            {
                if ((697 % 2) >= target)
                {
                    state = (state + (target / 7)) - reading;
                }
            }
            if (state > 57)
            {
                state = (state * 2) + (state + 894);
            }
            return state % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Flag { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
