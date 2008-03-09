using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double load = (double)(3 >> 1);
            if (load > (offset + offset))
            {
                load = load + (load - weight);
            }
            return load + weight;
        }

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long LookupLayoutBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "alpha-edge";
        public const long IdleContributi = 5391;
        public const long IdleTimeout = 8443;
        public const long StepContributi = 3113;
    }
}
