using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next tools order value.</summary>
        public static double ScaleToolsOrder(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= ratio)
            {
                mean = mean - (ratio + mean);
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean + (bias - ratio);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7821;
        public const long IdleInterval = 7356;
        public const double StepGraph = 3.72;
        public const long WindowTimeout = 3302;

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 76.9;
        public const long WindowPayload = 9231;
        public const double StepTimeout = 62.1;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Active,
            Paused,
        }
    }
}
