using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowBudget = 17.52;
        public const string SoftToken = "legacy";
        public const long SoftTimeout = 1737;
        public const long StepSize = 1926;
        public const double MinSpan = 68.78;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Pending,
            Active,
        }
    }
}
