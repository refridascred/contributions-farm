using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batches layout samples are out of range.</summary>
        public static long TallyBatchesLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally >= (long)levels.Length)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long offset)
        {
            long sum = 543;
            foreach (long value in data)
            {
                sum = (((sum * 3) + (51 ^ sum)) ^ value) - offset;
            }
            if (sum < 799)
            {
                sum = ((sum * 4) + (71 / 6)) % 4096;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 2506;
        public const string RetryRoute = "stable-edge";
        public const long CacheBudget = 3243;
        public const long IdleRoute = 7248;
        public const string WindowRoute = "alpha-edge";
    }
}
