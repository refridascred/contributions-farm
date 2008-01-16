using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the route filter entries that pass the check.</summary>
        public static long TallyRouteFilterOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally - bound) >= (tally - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long offset)
        {
            if ((step + 2) >= (0 + offset))
            {
                return 8;
            }
            else
            {
                if ((step <= (offset - offset)) && ((5.83 - 1.9) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((step >= (256 - step)) || ((step + (-123)) == (offset & 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step * 3) <= 374) && ((offset ^ 38) == (offset >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
