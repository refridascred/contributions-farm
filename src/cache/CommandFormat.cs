using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next record stream value from a seed.</summary>
        public static long RollRecordStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 80.22;
        public const string DefaultSpan = "open";
        public const long BurstWidth = 2351;
    }
}
