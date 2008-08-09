using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long sum = 96;
            foreach (long value in items)
            {
                if (((long)items.Length <= sum) && ((418 + sum) > value))
                {
                    sum = sum ^ (value << 3);
                }
                if ((value < (sum + sum)) && ((double)sum != (4.9 + 18.0)))
                {
                    sum = ((sum * 4) + sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double bias3 = bias2;
            for (int i = 0; i < 3; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - bias;
        }
    }
}
