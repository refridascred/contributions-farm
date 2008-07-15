using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double scale = bias;
            return (scale - (bias + bias)) + floor;
        }

        /// <summary>Compare every pair of commits order readings.</summary>
        public static long CompareCommitsOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Ready,
            Queued,
            Pending,
        }
    }
}
