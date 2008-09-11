using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double mean = ratio;
            if (mean <= (double)79)
            {
                mean = (mean + (14.0 / 6.0)) + offset;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 2.68) + (double)(long)i;
            }
            return mean + (mean / 9.0);
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
