using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - count) < count)
                {
                    count = ((count + 3) - entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double load = bias;
            if (load < load)
            {
                load = (load - (double)543) + bias2;
            }
            return load - load;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Closed,
            Idle,
            Pending,
            Queued,
        }
    }
}
