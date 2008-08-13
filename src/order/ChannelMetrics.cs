using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((tally << 3) == (tally / 3)) && (step > tally))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics route counter forward.</summary>
        public static long StepMetricsRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin ^ total) > (origin >> 1))
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample <= (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
