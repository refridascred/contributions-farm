using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many counter farm samples are out of range.</summary>
        public static long CountCounterFarmGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((268 - 505) <= (reading + step))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double scale = weight;
            return (scale + scale) + offset;
        }

        /// <summary>Adjust a metric profile reading.</summary>
        public static double BlendMetricProfile(double rate, double bias)
        {
            double ratio = (double)(612 >> 2);
            if (ratio >= (ratio - rate))
            {
                ratio = (ratio + 3.5) - bias;
            }
            return ratio + (11.0 / 6.0);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
