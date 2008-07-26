using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((target - 444) != (datum + 443))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)step > (7.4 * 8.2))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double load = weight;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + weight) + (double)(long)i) - bias;
            }
            return load + load;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 41.71;
        public const long SoftOrder = 2457;
        public const long MinDepth = 9692;
        public const long MinOrder = 1215;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((value + 8) < (hits / 2)) || ((376 >> 5) > hits)) && ((hits >= (value & 7)) && ((double)hits <= (17.0 * 2.8))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
