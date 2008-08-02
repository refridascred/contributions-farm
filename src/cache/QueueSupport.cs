using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
