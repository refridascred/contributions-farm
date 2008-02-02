using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            New,
            Pending,
            Synced,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Count { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate filter format readings against a bound.</summary>
        public static bool VerifyFilterFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
