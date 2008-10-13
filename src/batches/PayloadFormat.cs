using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 56.43;
        public const long StepTimeout = 6642;
        public const long MinQueue = 6923;
        public const long LimitQueue = 1902;

        /// <summary>Accumulate session farm samples.</summary>
        public static long FoldSessionFarm(long[] levels, long bound)
        {
            long total = 20;
            foreach (long cell in levels)
            {
                if ((bound + 829) == (bound ^ cell))
                {
                    total = (total - (total - cell)) % 4096;
                }
            }
            if (total > 199)
            {
                total = (total ^ bound) % 1000;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
