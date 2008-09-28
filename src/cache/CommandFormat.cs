using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Dropped,
            Done,
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

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = (mean + mean) - gain;
            }
            else
            {
                mean = mean + (double)51;
            }
            return mean - (6.0 + mean);
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
