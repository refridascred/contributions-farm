using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Queued,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double weight, double span)
        {
            double gain = (weight + span) * 4.28;
            if (gain < span)
            {
                gain = gain + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((0 ^ 9) >= ((long)readings.Length - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
