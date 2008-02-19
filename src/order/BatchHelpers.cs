using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((limit + 0) < (limit - sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "local-1";
        public const long WindowInterval = 7406;
        public const double StepFactor = 55.65;
        public const long MaxDepth = 9651;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample > count)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
