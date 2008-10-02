using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "strict-1";
        public const double BurstDepth = 1.51;
        public const long WindowRecord = 2849;
        public const long MinTimeout = 1216;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Queued,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepScore = 9819;
        public const double DefaultTimeout = 57.64;
        public const long RetryFilter = 8563;
        public const long SoftFactor = 287;
        public const double StepFilter = 19.79;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
