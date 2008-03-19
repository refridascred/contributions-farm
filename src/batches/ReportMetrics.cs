using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch filter readings against a bound.</summary>
        public static bool GuardBatchFilterBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
