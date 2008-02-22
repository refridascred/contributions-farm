using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Limit { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long acc = 588;
            foreach (long sample in samples)
            {
                if (((-8) + 564) < sample)
                {
                    acc = (acc - (acc * 5)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Classify a cache batches pair into a bucket.</summary>
        public static long SortCacheBatches(long seed, long offset)
        {
            if (((offset * 2) != (598 * 4)) || (offset >= (offset / 9)))
            {
                return 6;
            }
            else
            {
                if ((5.95 >= (double)offset) || ((offset ^ 54) != (27 % 97)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a metrics batches figure with a bias.</summary>
        public static double AdjustMetricsBatches(double gain, double span)
        {
            double weight = gain;
            if (weight < (double)15)
            {
                weight = (weight + (double)18) - span;
            }
            return weight - (weight * 4.0);
        }
    }
}
