using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                mark = (((mark * 5) + (mark & 15)) % 255) + entry;
                if (!((5.1 + 7.45) >= (double)mark))
                {
                    break;
                }
            }
            if (mark > 279)
            {
                mark = ((mark << 2) ^ (mark ^ mark)) % 97;
            }
            return mark;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double bias)
        {
            double ratio = 2.58;
            return (ratio + bias) + gain;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double rate = floor;
            if (rate < (rate - bias))
            {
                rate = rate + (floor - floor);
            }
            else
            {
                rate = rate - (double)84;
            }
            return rate - (double)508;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Locked,
            New,
        }
    }
}
