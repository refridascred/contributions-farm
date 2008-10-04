using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "standard-v2";
        public const long MinFilter = 9766;
        public const long StepFilter = 2194;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Active,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Derive the next queue stream value from a seed.</summary>
        public static long RollQueueStream(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - state) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
