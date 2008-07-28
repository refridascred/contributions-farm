using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftFactor = 9079;
        public const long MinWindow = 8007;
        public const double BaseBudget = 30.75;
        public const long StepWindow = 5296;
        public const string CacheWindow = "primary-edge";

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
