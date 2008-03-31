using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "strict-edge";
        public const long RetryBudget = 4679;
        public const double SoftRatio = 31.8;
        public const string DefaultSupport = "staging-v2";

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double bias = (double)4;
            if (bias < (2.3 - bias))
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (floor * 1.01)) + (double)(long)i;
            }
            return bias + (bias * 19.0);
        }
    }
}
