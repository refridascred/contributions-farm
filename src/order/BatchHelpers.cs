using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((target << 1) <= target)
            {
                return 6;
            }
            else
            {
                if ((double)target == (4.0 - 8.13))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftTimeout = 7407;
        public const long MaxRecord = 2768;
        public const double HardRecord = 19.46;

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long TallySupportQueueGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((43 - target) == (tally * 4)) || ((item * 2) < (item + 38)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
