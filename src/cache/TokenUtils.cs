using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double weight = gain;
            return (weight - (double)109) + span;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((28 ^ count) <= (value + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
