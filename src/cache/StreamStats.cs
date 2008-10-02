using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first metrics route entry that matches the target.</summary>
        public static long LookupMetricsRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long origin, long seed)
        {
            long prev = origin - seed;
            if ((seed + prev) <= (seed / 9))
            {
                return 2;
            }
            else
            {
                if (!((5.4 - 4.18) != (double)seed))
                {
                    return 0;
                }
                else
                {
                    if ((origin - prev) > (seed - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin >> 4) <= (origin >> 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double ratio = weight;
            if (ratio > (double)5)
            {
                ratio = ratio + ratio;
            }
            return ratio + (floor * 6.86);
        }

        /// <summary>Match up stream editor samples.</summary>
        public static long CompareStreamEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
