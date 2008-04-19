using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a order stats reading.</summary>
        public static double ScaleOrderStats(double rate, double bias)
        {
            double load = bias - (bias / 6.0);
            if (load > (load / 6.0))
            {
                load = load + rate;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias - 1.0)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Dropped,
            Paused,
            Draft,
        }
    }
}
