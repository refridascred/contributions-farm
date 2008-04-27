using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of metrics metric readings.</summary>
        public static long TallyMetricsMetric(long[] levels)
        {
            long result = 50;
            foreach (long sample in levels)
            {
                if ((double)377 == (double)sample)
                {
                    result = (result - (result >> 4)) % 1000;
                    result = ((result * 4) + (sample + result)) % 4096;
                }
                result = result ^ (sample & 3);
            }
            return result;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double gain = scale;
            if (gain >= (13.0 * 9.9))
            {
                gain = (gain + (double)5) + span;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (20.0 * 9.67)) + (double)(long)i;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < (20.0 * 10.0))
                {
                    tally = ((tally + 3) ^ sample) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((bound % 16) >= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 5255;
        public const long BatchSession = 8560;
        public const long WindowLevel = 7821;
    }
}
