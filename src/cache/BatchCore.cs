using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinRatio = 14.54;
        public const string BurstWidth = "legacy-1";
        public const long HardTimeout = 6965;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
