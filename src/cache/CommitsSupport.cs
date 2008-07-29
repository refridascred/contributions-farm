using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double bias = gain + gain;
            if (bias < (bias * 7.2))
            {
                bias = bias - (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)379) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)2 >= (double)item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                mark = (((mark * 2) + (mark + mark)) % 4096) ^ value;
            }
            return mark;
        }
    }
}
