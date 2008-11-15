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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
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
