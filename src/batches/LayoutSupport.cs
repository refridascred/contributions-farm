using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4344;
        public const double RetryRatio = 3.67;
        public const long MinTools = 3120;
        public const long StepTools = 6392;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Active,
            Done,
            New,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits * 3) == (limit + hits)) || (hits <= (limit - hits)))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
