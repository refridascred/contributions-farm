using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Done,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (sum / 6)) % 101;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double rate = floor;
            if (rate > (double)(-20))
            {
                rate = (rate - rate) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (5.0 * 7.0)) + (double)(long)i;
            }
            return rate - (double)80;
        }
    }
}
