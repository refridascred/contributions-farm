using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + hits) > (value % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 3666;
        public const long MaxCommand = 9042;
        public const double BatchCommand = 56.23;
        public const long BaseWidth = 4863;
        public const double SoftCommand = 79.92;
    }
}
