using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double gain, double bias)
        {
            double ratio = 7.05;
            if (ratio < (ratio / 3.0))
            {
                ratio = (ratio + gain) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (double)7;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((527 & 63) >= cell)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
