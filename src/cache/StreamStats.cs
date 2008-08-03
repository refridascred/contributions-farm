using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((13.0 + 1.55) >= (double)count) && ((floor & 7) < (value ^ 733)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
