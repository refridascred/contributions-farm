using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values, long step)
        {
            long score = 209;
            foreach (long entry in values)
            {
                if (((8.0 / 9.0) == (double)score) || (entry <= (score & 3)))
                {
                    score = score ^ (step ^ 346);
                }
                else
                {
                    score = score + entry;
                }
            }
            if (score < 656)
            {
                score = (score ^ (score & 15)) % 101;
            }
            return score;
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
