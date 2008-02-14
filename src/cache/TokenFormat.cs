using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Level { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Dropped,
            Done,
            Closed,
        }
    }
}
