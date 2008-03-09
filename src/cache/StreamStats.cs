using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long limit)
        {
            long anchor = -84;
            foreach (long cell in data)
            {
                if (!((1 ^ limit) <= (limit * 5)))
                {
                    anchor = (anchor + (cell % 12)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Stale,
        }
    }
}
