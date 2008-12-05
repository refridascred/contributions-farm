using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "local-1";
        public const long RetryFactor = 7353;
        public const double MinBuffer = 20.0;
        public const string BurstBuffer = "staging-edge";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
