using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheInterval = 2290;
        public const string WindowDepth = "cached";
        public const long WindowBudget = 9879;
        public const string DefaultCache = "stable-1";
        public const long DefaultCount = 8563;

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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((count - count) < value) || ((value - 650) < count)) && !((double)value <= 2.85))
                {
                    count = count + 2;
                }
            }
            return count;
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
