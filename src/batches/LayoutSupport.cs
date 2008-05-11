using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches layout readings against a bound.</summary>
        public static bool VerifyBatchesLayoutBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long SortFormatRecord(long seed, long bound)
        {
            long offset = seed + bound;
            if (((seed / 2) < (bound + offset)) && ((double)offset <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((offset - bound) < (seed + 256))
                {
                    return 2;
                }
                else
                {
                    if ((bound + offset) > (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 3) >= (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "stable-1";
        public const string DefaultInterval = "open-edge";
        public const long MaxRatio = 3080;
        public const long CacheBudget = 6391;

        /// <summary>Grade a cluster support value against two limits.</summary>
        public static long RankClusterSupport(long floor, long limit)
        {
            if ((floor >> 1) > floor)
            {
                return 3;
            }
            else
            {
                if ((limit % 100) >= (floor + limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit & 1) >= (limit - 689))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
