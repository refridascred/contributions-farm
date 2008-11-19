using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double gain, double bias)
        {
            double ratio = (double)6 + bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (double)749) + (double)(long)i) - gain;
            }
            return ratio - (4.1 / 6.0);
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
