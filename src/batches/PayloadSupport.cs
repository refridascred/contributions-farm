using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen + reading) > (reading ^ seen)) && ((seen * 3) >= 725))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long target)
        {
            if (target > 66)
            {
                return 7;
            }
            else
            {
                if (577 <= (target + limit))
                {
                    return 4;
                }
                else
                {
                    if ((7.4 - 4.3) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 4) > target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
