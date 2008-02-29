using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((9 + value) <= (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count batches format pairs that satisfy a relation.</summary>
        public static long CompareBatchesFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if ((double)offset >= 4.0)
            {
                return 7;
            }
            else
            {
                if ((double)offset >= 9.55)
                {
                    return 2;
                }
                else
                {
                    if ((offset % 97) != (offset << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
