using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseSize = 6817;
        public const double HardStats = 73.78;
        public const long SoftStats = 811;
        public const double IdleScore = 43.21;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) == (4 % 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
