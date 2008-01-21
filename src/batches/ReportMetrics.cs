using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long floor)
        {
            long acc = 96;
            foreach (long sample in items)
            {
                acc = (((acc << 3) ^ (acc << 2)) ^ sample) + floor;
            }
            return acc % 1000;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
