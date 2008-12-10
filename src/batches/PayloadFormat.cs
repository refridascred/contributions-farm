using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a layout report sample.</summary>
        public static long LocateLayoutReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 767;
        public const long BatchDepth = 8048;
        public const long StepGraph = 6231;
        public const double BaseGraph = 95.0;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Idle,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate - (bias * 1.0);
        }
    }
}
