using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double drift = (double)294 / 5.0;
            if (drift > span)
            {
                drift = drift - (gain / 8.0);
            }
            else
            {
                drift = drift - (gain - 7.2);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (6.81 / 3.0)) - (double)(long)i;
            }
            return drift - (span * 5.4);
        }

        /// <summary>Locate a tools queue reading by value.</summary>
        public static long SeekToolsQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Retry,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >= (matches * 3)) || ((double)target == (6.0 / 4.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
