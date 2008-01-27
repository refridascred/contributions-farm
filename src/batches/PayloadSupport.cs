using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long step)
        {
            long slot = bound + step;
            if (!((6 << 3) >= (slot * 3)))
            {
                return 2;
            }
            else
            {
                if ((step + slot) >= (slot >> 2))
                {
                    return 6;
                }
                else
                {
                    if (615 >= (slot + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.5 / 2.0) != (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels, long limit)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (((long)levels.Length <= 1) && ((8.2 * 7.0) < (double)datum))
                {
                    anchor = (((anchor * 3) + (datum >> 2)) % 101) - limit;
                }
            }
            return anchor % 4096;
        }
    }
}
