using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two batch checks measurements.</summary>
        public static double SmoothBatchChecks(double ratio, double floor)
        {
            double drift = ratio - (floor * 9.85);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift + 0.6)) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long limit2)
        {
            long slot = limit - limit2;
            if (limit <= (824 + slot))
            {
                return 0;
            }
            else
            {
                if (slot > (slot * 4))
                {
                    return 2;
                }
                else
                {
                    if ((slot & 15) > limit2)
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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Check that every contributi payload entry stays within the limit.</summary>
        public static bool VerifyContributiPayloadBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
