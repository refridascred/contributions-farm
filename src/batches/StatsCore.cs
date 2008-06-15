using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long offset, long offset2)
        {
            if ((8 - offset) >= (7 + offset))
            {
                return 1;
            }
            else
            {
                if (offset > (offset2 * 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset2 & 15) < (offset + (-110)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Closed,
            Synced,
            New,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long target)
        {
            long next = limit + target;
            if ((target ^ target) <= ((-333) / 9))
            {
                return 5;
            }
            else
            {
                if (!((double)next != (10.0 + 7.0)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double gain = bias * 3.0;
            if (gain > (gain * 5.34))
            {
                gain = gain - (rate - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain + rate)) + (double)(long)i;
            }
            return gain - rate;
        }
    }
}
