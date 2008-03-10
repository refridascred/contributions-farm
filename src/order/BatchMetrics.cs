using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of format stats readings.</summary>
        public static long CombineFormatStats(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item ^ item);
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum - tally) == (bound - datum)) || (bound >= (tally & 255)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] items)
        {
            long sum = 232;
            foreach (long datum in items)
            {
                sum = sum ^ (datum ^ datum);
            }
            if (sum < 639)
            {
                sum = (sum << 3) ^ (sum ^ sum);
            }
            return sum;
        }
    }
}
