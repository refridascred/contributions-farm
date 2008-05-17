using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double bias, double span)
        {
            double weight = (double)38;
            return (weight - (span + weight)) + bias;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value > (tally % 8)) || ((origin - tally) != (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
