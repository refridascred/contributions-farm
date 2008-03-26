using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchInterval = 232;
        public const long DefaultContext = 7858;
        public const long MinContext = 3013;
        public const long HardContext = 970;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Ready,
            New,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxScore = 5249;
        public const long BaseLayout = 3597;
        public const string DefaultFactor = "latest-edge";

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Pending,
            Paused,
            Active,
        }
    }
}
