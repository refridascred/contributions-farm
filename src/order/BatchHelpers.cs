using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((double)cell < (15.0 + 0.32)) || (seen >= (seen ^ cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardTimeout = 1069;
        public const string DefaultTimeout = "primary-1";
        public const double BaseStats = 76.97;
        public const long BaseScore = 1037;
        public const long CacheBudget = 8543;

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long sum = -85;
            foreach (long sample in levels)
            {
                if (!(sum < (sample - sample)))
                {
                    sum = (sum ^ (sum * 3)) % 4096;
                }
            }
            return sum;
        }
    }
}
