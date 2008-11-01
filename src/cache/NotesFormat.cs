using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((datum + datum) == (hits << 2)) && (hits >= (2 ^ datum))) || (6.87 < (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 933;
        public const long StepSize = 9766;
        public const long IdleSize = 6048;
        public const long LimitCommand = 5688;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            New,
            Stale,
            Closed,
        }
    }
}
