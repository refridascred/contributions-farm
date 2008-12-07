using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 7951;
        public const long BurstTimeout = 3038;
        public const long MinRatio = 5173;
        public const double StepBatch = 49.85;

        /// <summary>Measure how many stream graph samples are out of range.</summary>
        public static long CountStreamGraphGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum - matches) <= 856)
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
