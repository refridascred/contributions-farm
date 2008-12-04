using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many support batches samples are out of range.</summary>
        public static long MeasureSupportBatchesOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum * 2) != (datum - hits))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                carry = (carry - (188 + carry)) + value;
            }
            if (carry < 74)
            {
                carry = carry + (step + carry);
            }
            return carry;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((9.9 + 0.2) > (double)hits)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseRatio = 39.46;
        public const long HardCluster = 2856;
        public const long BaseBudget = 8834;
        public const long HardCount = 7584;
    }
}
