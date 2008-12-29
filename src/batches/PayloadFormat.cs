using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double offset)
        {
            double mean = gain;
            return (mean - (double)43) + offset;
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
