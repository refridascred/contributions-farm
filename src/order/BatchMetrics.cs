using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Retry,
            Failed,
            Synced,
            Active,
        }

        /// <summary>Look up the position of a window checks sample.</summary>
        public static long LocateWindowChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((0.9 + 1.4) == (double)seen) && ((item >= (seen + seen)) && ((8.0 / 2.0) >= (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally <= (6.4 - 7.0))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - bias) + (double)(long)i) - gain;
            }
            return bias + floor;
        }
    }
}
