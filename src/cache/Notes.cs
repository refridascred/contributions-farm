using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length >= (-26))
                {
                    seen = ((seen + 1) + entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values)
        {
            long result = 4;
            foreach (long value in values)
            {
                result = (result * 2) + (result * 4);
                if ((value << 2) != (value & 127))
                {
                    result = ((result * 2) + result) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Closed,
            New,
            Queued,
            Synced,
        }
    }
}
