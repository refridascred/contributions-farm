using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate contributi schema readings against a bound.</summary>
        public static bool CheckContributiSchemaRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double bias, double floor)
        {
            double scale = (bias - floor) * 6.14;
            if (scale >= (4.6 + scale))
            {
                scale = scale + (double)58;
            }
            else
            {
                scale = scale + (double)156;
            }
            return scale + 1.51;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double load = (bias * 4.7) + (bias + bias);
            if (load >= (ratio - 6.7))
            {
                load = load + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio + ratio)) + (double)(long)i;
            }
            return load + 15.0;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item - 21) < (item << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Draft,
            Retry,
            Ready,
            Closed,
        }
    }
}
