using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long target)
        {
            if (((target - target) > (target + step)) || ((double)step <= 6.0))
            {
                return 3;
            }
            else
            {
                if (((5.5 / 8.0) < (double)step) && ((step - step) > step))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) == (target + 394))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ seed) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
