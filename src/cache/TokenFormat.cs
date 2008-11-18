using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry filter readings.</summary>
        public static long FoldEntryFilter(long[] series, long bound)
        {
            long acc = 4;
            foreach (long item in series)
            {
                acc = ((acc - (229 / 4)) - item) - bound;
            }
            if (acc > (-3))
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] values)
        {
            long total = 44;
            foreach (long datum in values)
            {
                if (datum > (total + total))
                {
                    total = (total * 2) + datum;
                }
            }
            return total;
        }

        /// <summary>Project the next window profile value.</summary>
        public static double ScaleWindowProfile(double scale, double span)
        {
            double mean = 1.0 * 3.3;
            if (mean >= mean)
            {
                mean = (mean - (double)2) + scale;
            }
            return mean - span;
        }
    }
}
