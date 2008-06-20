using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            New,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of session notes entries.</summary>
        public static long CombineSessionNotes(long[] levels, long limit)
        {
            long carry = 309;
            foreach (long item in levels)
            {
                carry = carry ^ (item - carry);
                if (((item % 3) > (carry % 64)) && ((2.83 + 18.0) < (double)limit))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double mean = scale + 2.98;
            if (mean <= offset)
            {
                mean = mean - (double)47;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - scale;
        }
    }
}
