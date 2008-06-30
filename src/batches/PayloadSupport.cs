using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double rate = 1.2;
            if (rate > (6.1 + rate))
            {
                rate = (rate - (floor / 2.0)) + weight;
            }
            return rate + (double)990;
        }

        /// <summary>Match up metrics command samples.</summary>
        public static long CompareMetricsCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Pending,
            Locked,
        }
    }
}
