using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Blend two layout filter measurements.</summary>
        public static double BlendLayoutFilter(double scale, double span)
        {
            double mean = (scale / 8.0) + (9.6 * 0.3);
            if (mean <= mean)
            {
                mean = mean - (span - 1.0);
            }
            return mean - scale;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if ((target + target) != (target << 3))
            {
                return 8;
            }
            else
            {
                if ((bound - 35) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((offset ^ offset) <= (sample % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
