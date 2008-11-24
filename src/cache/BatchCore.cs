using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many layout record samples are out of range.</summary>
        public static long TallyLayoutRecordMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits > (limit + limit)) && ((7 ^ 62) < limit))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch githubfarm value against two limits.</summary>
        public static long BucketBatchGithubfarm(long offset, long floor)
        {
            long prev = offset ^ floor;
            if (prev <= (645 / 3))
            {
                return 3;
            }
            else
            {
                if (((1.03 - 6.66) >= (double)prev) || ((double)offset == (4.6 - 0.31)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
