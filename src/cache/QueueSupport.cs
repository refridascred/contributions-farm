using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5782;
        public const long WindowSpan = 6857;
        public const long LimitStream = 1118;
        public const long MaxStream = 7724;
        public const long StepLevel = 6496;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Queued,
            Active,
            Stale,
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double weight = (double)(936 & 255);
            return ((weight - 4.3) + rate) + offset;
        }
    }
}
