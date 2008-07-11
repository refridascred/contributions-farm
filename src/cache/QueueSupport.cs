using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the cluster account entries that pass the check.</summary>
        public static long TallyClusterAccountOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value != (0.62 / 9.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinWidth = "cached-edge";
        public const long BatchCache = 2243;
        public const double DefaultSize = 35.81;
        public const long BatchRatio = 8652;

        /// <summary>Scale a editor checks figure with a bias.</summary>
        public static double BlendEditorChecks(double gain, double bias)
        {
            double rate = (double)885;
            if (rate < gain)
            {
                rate = (rate + 17.0) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (double)7;
        }
    }
}
