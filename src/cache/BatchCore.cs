using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Paused,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Compare every pair of record githubfarm readings.</summary>
        public static long CompareRecordGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
