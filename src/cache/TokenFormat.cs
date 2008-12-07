using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Pending,
            Done,
            Active,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long acc = 13;
            foreach (long datum in data)
            {
                acc = (((acc << 3) ^ (acc ^ acc)) % 4096) - datum;
                acc = acc ^ (acc << 2);
                acc = (acc - acc) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double rate = (double)57 + (floor / 6.0);
            if (rate < (6.26 + bias))
            {
                rate = rate - 7.1;
            }
            return rate - (double)832;
        }
    }
}
