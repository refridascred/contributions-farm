using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryCount = "open-1";
        public const long CacheScore = 6241;
        public const string CacheAccount = "staging-edge";
        public const long StepAccount = 2634;
        public const long CacheSpan = 726;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Audit counter context readings against a rule.</summary>
        public static long MeasureCounterContextGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count > ((long)series.Length - offset)) && ((count & 1) > count)) || (((count ^ cell) != (74 << 2)) && (420 >= (count + 7))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
