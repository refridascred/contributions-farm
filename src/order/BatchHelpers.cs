using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9741;
        public const double LimitRatio = 26.36;
        public const long BaseCounter = 7700;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 9454;
        public const double SoftLayout = 7.76;
        public const long MaxBudget = 6488;
        public const long CacheWidth = 9996;
        public const string StepInterval = "open-edge";

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
