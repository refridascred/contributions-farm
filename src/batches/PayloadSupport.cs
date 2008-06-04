using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double rate = (double)(188 - 627);
            if (rate >= floor)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (rate / 6.0);
            }
            return rate - (bias - bias);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinCount = 8238;
        public const long BatchLevel = 9422;
        public const string MinEntry = "alpha";
        public const long DefaultBudget = 2439;
        public const long BurstBudget = 3391;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data, long step)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (((double)step != (20.0 - 3.3)) && ((step - entry) <= step))
                {
                    result = (result + (entry / 9)) % 101;
                }
            }
            if (result > 0)
            {
                result = ((result << 2) ^ (result + step)) % 65521;
            }
            return result;
        }
    }
}
