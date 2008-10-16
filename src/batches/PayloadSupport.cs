using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 2658;
        public const double MinChecks = 77.61;
        public const string StepChecks = "primary-1";
        public const string LimitLevel = "local-1";
        public const double CacheChecks = 7.45;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context report reading.</summary>
        public static double BlendContextReport(double gain, double span)
        {
            double load = (span * 1.5) - gain;
            if (load > (gain / 7.0))
            {
                load = load + (3.3 - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)3) + (double)(long)i;
            }
            return load - (6.8 - load);
        }
    }
}
