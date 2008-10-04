using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseRatio = "alpha";
        public const string StepBatches = "open-edge";
        public const long MaxBatches = 2363;

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((double)matches == (3.1 - 6.47)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleLevel = 5308;
        public const double SoftFormat = 17.99;
        public const double StepInterval = 33.96;
        public const long CacheInterval = 2286;
        public const long MaxLevel = 8690;
    }
}
