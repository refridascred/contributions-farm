using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a payload checks reading.</summary>
        public static double SmoothPayloadChecks(double weight, double offset)
        {
            double drift = 10.0 - (double)(-65);
            if (drift <= drift)
            {
                drift = ((drift - (double)17) - weight) + offset;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxTimeout = 6.12;
        public const long StepInterval = 2923;
        public const long BatchFormat = 3238;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
