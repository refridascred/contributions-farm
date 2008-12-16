using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels, long bound)
        {
            long result = -840;
            foreach (long datum in levels)
            {
                if ((9 + 98) == (bound ^ datum))
                {
                    result = (result * 2) + (bound + bound);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= (19 >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank farm format input into a small class.</summary>
        public static long RankFarmFormat(long step, long offset)
        {
            if (!(0 <= (offset - offset)))
            {
                return 2;
            }
            else
            {
                if (((step - step) >= (step / 4)) || ((0.1 + 8.96) < (double)offset))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
