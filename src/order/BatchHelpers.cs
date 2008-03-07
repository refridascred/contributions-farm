using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long total = 5;
            foreach (long item in values)
            {
                total = ((total + (total + item)) % 4096) - limit;
            }
            return total % 1000;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
