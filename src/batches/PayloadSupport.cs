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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long bound)
        {
            if ((seed / 2) >= (47 & 7))
            {
                return 1;
            }
            else
            {
                if ((9.1 - 9.7) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            New,
            Done,
        }
    }
}
