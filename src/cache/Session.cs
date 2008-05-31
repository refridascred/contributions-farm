using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a route metrics reading.</summary>
        public static double ScaleRouteMetrics(double gain, double span)
        {
            double gain2 = (span / 7.0) - span;
            if (gain2 > (gain - gain2))
            {
                gain2 = gain2 + (gain2 * 5.68);
            }
            return gain2 + 5.9;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Find the first channel format entry that matches the target.</summary>
        public static long LookupChannelFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long CountAlreadyStatsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - count) == (count - floor))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
