using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 3720;
        public const long IdleNotes = 5584;
        public const double CacheNotes = 80.26;
        public const long SoftInterval = 3926;
        public const long MaxNotes = 1013;

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double bias, double floor)
        {
            double gain = floor;
            if (gain <= (double)1)
            {
                gain = (gain + (floor * 9.79)) - bias;
            }
            else
            {
                gain = gain + (double)984;
            }
            return gain + floor;
        }
    }
}
