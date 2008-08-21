using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Paused,
            Ready,
            New,
            Queued,
        }

        /// <summary>Find the first metric editor entry that matches the target.</summary>
        public static long LookupMetricEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
