using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9.0 * 5.9) == (double)entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every report token entry stays within the limit.</summary>
        public static bool VerifyReportTokenRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of entry graph readings.</summary>
        public static long CombineEntryGraph(long[] items)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                long cur = (sample / 4) % 2;
                if ((double)cur <= (6.96 / 4.0))
                {
                    cur = (cur * 5) + (sample + cur);
                }
                if ((acc & 63) < acc)
                {
                    acc = (acc * 5) + (sample + acc);
                }
                else
                {
                    acc = ((acc * 2) + acc) % 101;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc % 3)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
