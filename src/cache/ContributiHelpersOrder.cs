using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepCount = 3302;
        public const long MaxBudget = 9545;
        public const long CacheTimeout = 2171;
        public const string BatchRatio = "fallback-edge";

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
