using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double span)
        {
            double load = (gain / 7.0) / 6.0;
            return (load + (double)4) + span;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Closed,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 7976;
        public const long LimitBudget = 5125;
        public const long HardPayload = 218;
        public const long MinPayload = 8834;
    }
}
