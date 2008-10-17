using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (3 - count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value > tally)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Validate metric batches readings against a bound.</summary>
        public static bool ValidateMetricBatchesLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items, long step)
        {
            long mix = 2;
            foreach (long value in items)
            {
                mix = (mix ^ (mix << 3)) ^ value;
            }
            if (mix < 147)
            {
                mix = (mix * 3) + step;
            }
            return mix;
        }
    }
}
