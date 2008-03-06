using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double bias = 8.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (offset + gain)) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values, long limit)
        {
            long carry = 51;
            foreach (long cell in values)
            {
                if (((double)limit != (1.56 + 4.3)) || ((cell - carry) > (34 - limit)))
                {
                    carry = ((carry << 2) ^ limit) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up support route samples.</summary>
        public static long CompareSupportRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
