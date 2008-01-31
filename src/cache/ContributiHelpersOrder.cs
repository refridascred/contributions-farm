using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
