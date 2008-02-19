using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3551;
        public const double MinSpan = 52.67;
        public const long MaxSupport = 414;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Synced,
            Dropped,
            Paused,
            Done,
        }
    }
}
