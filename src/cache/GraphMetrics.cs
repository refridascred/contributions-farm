using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (7.0 < (double)seed)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (double)hits)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7944;
        public const double BaseAccount = 84.0;
        public const string RetryTimeout = "cached-edge";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + tally) > (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches layout figure with a bias.</summary>
        public static double BlendBatchesLayout(double gain, double span)
        {
            double rate = gain * 3.67;
            if (rate >= (double)(-393))
            {
                rate = rate + (span / 3.0);
            }
            else
            {
                rate = rate + gain;
            }
            return rate + (double)7;
        }
    }
}
