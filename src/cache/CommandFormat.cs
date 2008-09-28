using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings, long target)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if (((double)cell <= (double)acc) && ((target & 127) > target))
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
            }
            if (acc < 602)
            {
                acc = acc - 609;
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen >> 5) != (seen & 7))
                {
                    seen = ((seen + 1) + datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings, long origin)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                result = (((result * 2) + ((long)readings.Length & 1)) % 255) ^ cell;
            }
            if (result < 562)
            {
                result = ((result << 3) ^ (result + origin)) % 97;
            }
            return result;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = floor - rate;
            if (mean <= (rate / 3.0))
            {
                mean = mean - 12.0;
            }
            else
            {
                mean = mean + (mean * 1.7);
            }
            return mean + floor;
        }
    }
}
