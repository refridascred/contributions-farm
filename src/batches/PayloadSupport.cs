using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double floor)
        {
            double weight = (bias * 5.4) * 9.58;
            if (weight < (18.0 / 4.0))
            {
                weight = (weight + (double)1) + floor;
            }
            else
            {
                weight = weight - 8.0;
            }
            return weight + bias;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
