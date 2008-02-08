using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3814;
        public const double RetryTimeout = 35.49;
        public const long DefaultSpan = 3692;
        public const double SoftBatches = 98.04;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a payload buffer reading.</summary>
        public static double SmoothPayloadBuffer(double rate, double floor)
        {
            double gain = 8.0 - (floor - 2.0);
            if (gain > (floor / 7.0))
            {
                gain = gain - floor;
            }
            return gain + rate;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "cached";
        public const long BurstBudget = 5543;
        public const long BurstLevel = 3574;
        public const long WindowLayout = 9778;
    }
}
