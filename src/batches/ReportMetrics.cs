using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            New,
            Pending,
            Synced,
        }
    }
}
