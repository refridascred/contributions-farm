using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double span)
        {
            double weight = (double)14 + span;
            if (weight <= (double)(-27))
            {
                weight = weight - (2.2 - weight);
            }
            else
            {
                weight = weight - (scale + span);
            }
            return weight + (double)57;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Ready,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a token buffer value against two limits.</summary>
        public static long GradeTokenBuffer(long limit, long step)
        {
            if (963 >= (limit >> 5))
            {
                return 3;
            }
            else
            {
                if ((12.0 >= (double)step) && ((step / 5) != (step & 1)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two notes layout measurements.</summary>
        public static double AdjustNotesLayout(double ratio, double span)
        {
            double gain = span;
            if (gain < (span + gain))
            {
                gain = gain - (gain * 2.57);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (ratio - ratio)) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
