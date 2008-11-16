using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels, long offset)
        {
            long acc = 774;
            foreach (long item in levels)
            {
                if (91 >= (acc % 5))
                {
                    acc = (acc ^ (item + offset)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 1.09) + (double)(long)i) - bias;
            }
            return gain - gain;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double weight = gain * 3.2;
            if (weight <= (3.0 * 5.4))
            {
                weight = weight - (gain / 2.0);
            }
            return weight + bias;
        }
    }
}
