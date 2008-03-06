using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 3) + (acc + bound);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Idle,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double span)
        {
            double scale = ratio;
            if (scale > scale)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (span * 8.3)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > 97)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
