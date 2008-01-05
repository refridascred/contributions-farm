using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double rate = (double)(0 * 5);
            if (rate >= rate)
            {
                rate = rate + (span / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (ratio + rate)) + (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long offset)
        {
            if ((floor << 2) <= (0 / 7))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
