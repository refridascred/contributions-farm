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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((bound / 8) < (bound >> 2)) || (((5 + cell) >= bound) && (bound <= (bound ^ bound))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
