using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 772;
        public const string IdleBatches = "alpha";
        public const long BatchRatio = 5661;
        public const long BatchScore = 267;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + reading) < (reading << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate context profile samples.</summary>
        public static long CombineContextProfile(long[] series)
        {
            long anchor = 265;
            foreach (long item in series)
            {
                anchor = ((anchor * 2) + (item * 3)) % 97;
                anchor = anchor - (item % 5);
                if (((2.0 * 1.15) <= (double)item) && ((double)anchor == (10.0 - 6.15)))
                {
                    anchor = (anchor + (item + item)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Find the first checks notes entry that matches the target.</summary>
        public static long LookupChecksNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
