using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultInterval = 8983;
        public const double MaxBudget = 80.32;
        public const double MinNotes = 35.54;

        /// <summary>Count the batch payload entries that pass the check.</summary>
        public static long MeasureBatchPayloadHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value < (seed + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long origin)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                if (6 <= (result - sample))
                {
                    result = ((result << 3) ^ (63 ^ sample)) % 97;
                }
            }
            if (result > 83)
            {
                result = ((result * 2) + (result + origin)) % 101;
            }
            return result % 65521;
        }
    }
}
