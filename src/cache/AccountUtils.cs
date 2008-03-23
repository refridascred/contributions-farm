using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (4.0 - 6.0))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double bias2 = bias + (double)8;
            if (bias2 >= 5.0)
            {
                bias2 = (bias2 + bias) + gain;
            }
            return bias2 - (double)3;
        }
    }
}
