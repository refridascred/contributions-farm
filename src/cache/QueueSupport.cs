using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Closed,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally <= (double)target)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a order profile figure with a bias.</summary>
        public static double BlendOrderProfile(double weight, double bias)
        {
            double bias2 = 6.0;
            if (bias2 < (double)1)
            {
                bias2 = (bias2 - bias) - weight;
            }
            return bias2 - (double)(-42);
        }
    }
}
