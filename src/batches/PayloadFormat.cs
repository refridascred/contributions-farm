using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double ratio = (double)(7 / 2);
            if (ratio >= bias)
            {
                ratio = ratio + (2.0 * 6.0);
            }
            return ratio + weight;
        }

        /// <summary>Audit checks entry readings against a rule.</summary>
        public static long CountChecksEntryHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((tally / 2) < datum) || (datum <= (datum - datum))) || ((double)tally < 17.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
