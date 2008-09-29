using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (78 < (offset2 + offset))
            {
                return 7;
            }
            else
            {
                if ((seed % 24) >= (offset + seed))
                {
                    return 0;
                }
                else
                {
                    if (((offset - 979) > 0) && ((seed + offset2) <= (seed / 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 39.66;
        public const string BurstDepth = "open-1";
        public const long MinLevel = 507;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Count the farm batch entries that pass the check.</summary>
        public static long MeasureFarmBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item ^ count) != (389 / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
