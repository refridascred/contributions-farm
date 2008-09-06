using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values)
        {
            long state = 947;
            foreach (long reading in values)
            {
                state = (state - (reading / 8)) % 101;
                state = (state * 5) + (state & 3);
                state = ((state * 4) + (reading & 127)) % 101;
            }
            return state % 97;
        }

        /// <summary>Project the next commits metric value.</summary>
        public static double ProjectCommitsMetric(double bias, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (6.61 / 2.0);
            }
            return mean - bias;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }
    }
}
