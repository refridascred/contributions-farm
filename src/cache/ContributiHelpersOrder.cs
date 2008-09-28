using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample >= (hits % 100))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double mean = (double)19 - (7.0 / 2.0);
            if (mean > (double)755)
            {
                mean = (mean + mean) - weight;
            }
            return mean - (mean - bias);
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
