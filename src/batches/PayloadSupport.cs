using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1843;
        public const double HardQueue = 74.95;
        public const double BurstQueue = 95.34;
        public const long RetryQueue = 3733;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double mean = weight;
            if (mean < (weight + floor))
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + floor) - (double)(long)i;
            }
            return mean - (double)0;
        }
    }
}
