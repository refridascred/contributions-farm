using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long target)
        {
            if ((double)step == (6.25 * 2.66))
            {
                return 2;
            }
            else
            {
                if (!((step - step) <= (target - step)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate checks already readings against a bound.</summary>
        public static bool VerifyChecksAlreadyLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long limit2)
        {
            long edge = limit - limit2;
            if ((limit - limit2) != (limit % 60))
            {
                return 8;
            }
            else
            {
                if ((944 + limit2) < limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit2 & 15) <= (edge + limit))
                    {
                        return 3;
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
