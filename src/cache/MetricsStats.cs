using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Locked,
            Idle,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long offset)
        {
            long edge = step - offset;
            if ((9 / 2) < (step % 7))
            {
                return 3;
            }
            else
            {
                if ((double)edge <= (5.95 - 19.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double rate = span / 5.0;
            if (rate < rate)
            {
                rate = (rate - rate) + ratio;
            }
            return rate - (double)966;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) > value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
