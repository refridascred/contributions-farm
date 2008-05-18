using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen > (seen % 60))
                {
                    seen = ((seen + 2) + value) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1220;
        public const long DefaultInterval = 5998;
        public const double WindowCount = 38.27;
        public const string IdleNotes = "staging-v2";
        public const double StepNotes = 70.93;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
