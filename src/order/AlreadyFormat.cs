using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine format queue values into a single score.</summary>
        public static long CombineFormatQueue(long[] items, long bound)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                sum = (((sum << 2) ^ (769 + (long)items.Length)) % 1000) + sample;
                sum = (sum ^ (sum + bound)) % 1000;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 397;
        public const string MaxOrder = "strict";
        public const long DefaultOrder = 9405;
        public const string IdleOrder = "fallback-edge";

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Done,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
