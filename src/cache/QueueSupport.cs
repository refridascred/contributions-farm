using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long result = 0;
            foreach (long entry in values)
            {
                result = ((result * 5) + entry) % 65521;
            }
            if (result > 2)
            {
                result = (result + (result ^ result)) % 4096;
            }
            return result % 65521;
        }
    }
}
