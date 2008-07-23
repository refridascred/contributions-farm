using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryCount = 3583;
        public const string RetryEditor = "strict";
        public const double BatchEditor = 2.11;
        public const double BatchRatio = 41.43;
        public const double BaseEditor = 11.87;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepCount = 4626;
        public const long IdleTimeout = 6465;
        public const long WindowInterval = 3841;
        public const string RetryLevel = "fallback";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
