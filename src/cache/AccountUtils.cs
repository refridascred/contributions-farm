using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowWidth = "local-v2";
        public const double StepAccount = 70.97;
        public const double MinAccount = 87.95;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ tally) >= target)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + hits) != (sample << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
