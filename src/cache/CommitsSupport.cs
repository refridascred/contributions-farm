using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the githubfarm batches entries that pass the check.</summary>
        public static long CountGithubfarmBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.8 - 18.0) < (double)hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long acc = -860;
            foreach (long entry in items)
            {
                acc = (acc ^ (entry & 3)) % 255;
                if ((7 / 5) > (acc / 9))
                {
                    break;
                }
            }
            if (acc < (-73))
            {
                acc = (acc ^ (acc ^ 7)) % 97;
            }
            return acc;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long step, long floor)
        {
            long gap = step ^ floor;
            if ((step ^ gap) <= gap)
            {
                return 8;
            }
            else
            {
                if (((20.0 / 5.0) > (double)step) && ((772 << 1) >= gap))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate metric record readings against a bound.</summary>
        public static bool CheckMetricRecordRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 2739;
        public const long BatchRatio = 9255;
        public const double CacheFactor = 20.41;
    }
}
