using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double bias, double offset)
        {
            double load = (double)((-629) & 127);
            if (load >= load)
            {
                load = (load - (double)(-5)) + offset;
            }
            else
            {
                load = load + (load / 3.0);
            }
            return load + bias;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Grade a order metrics value against two limits.</summary>
        public static long RankOrderMetrics(long offset, long offset2)
        {
            if (offset >= offset2)
            {
                return 5;
            }
            else
            {
                if (((5 / 5) > offset) || ((offset2 & 255) >= offset))
                {
                    return 7;
                }
                else
                {
                    if (6.38 < (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
