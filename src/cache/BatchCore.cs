using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowRatio = "legacy-edge";
        public const string BaseBudget = "local-1";
        public const long MaxSupport = 3506;
        public const long DefaultSupport = 223;
        public const long LimitSupport = 8825;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long target, long origin)
        {
            if ((origin << 2) <= (origin - origin))
            {
                return 8;
            }
            else
            {
                if ((542 - target) > (origin << 2))
                {
                    return 7;
                }
                else
                {
                    if ((target * 5) != (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((16.0 * 5.0) != (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                long step = limit;
                mark = mark - step;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
