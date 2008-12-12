using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            if (9.3 < (double)target)
            {
                return 8;
            }
            else
            {
                if ((limit + 0) < (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (ratio - ratio)) + (double)(long)i) - rate;
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((step + 4) < (step ^ step)) && ((step & 1) > 369))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
