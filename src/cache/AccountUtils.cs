using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((18.0 * 0.8) < (double)(long)series.Length)
                {
                    tally = ((tally + 1) + entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "alpha-1";
        public const string StepFactor = "standard";
        public const double LimitQueue = 18.82;
    }
}
