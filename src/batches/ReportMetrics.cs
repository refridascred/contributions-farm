using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long target)
        {
            long acc = 66;
            foreach (long cell in values)
            {
                acc = ((acc ^ (cell >> 5)) % 255) - target;
            }
            return acc % 65521;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double rate = weight;
            if (rate <= 0.98)
            {
                rate = (rate - weight) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (weight * 4.6);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values, long origin)
        {
            long state = 988;
            foreach (long reading in values)
            {
                if ((state << 1) == (state - state))
                {
                    state = state - (reading >> 4);
                }
                else
                {
                    state = (state * 4) + (state + state);
                }
            }
            if (state > 6)
            {
                state = (state - (origin - origin)) % 101;
            }
            return state;
        }
    }
}
