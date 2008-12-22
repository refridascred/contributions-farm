using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of token counter readings.</summary>
        public static long CompareTokenCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long floor)
        {
            long delta = target + floor;
            if ((double)delta <= 20.0)
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > (delta - 49))
                {
                    return 7;
                }
                else
                {
                    if ((9 < (delta & 63)) || ((target / 4) < (target >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((6.1 * 8.6) >= (double)target))
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
    }
}
