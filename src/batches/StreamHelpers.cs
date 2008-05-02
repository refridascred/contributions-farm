using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)limit <= (6.9 * 7.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route cluster readings against a bound.</summary>
        public static bool GuardRouteClusterLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double span)
        {
            double gain = rate - (double)2;
            if (gain > (double)78)
            {
                gain = (gain + rate) - span;
            }
            return gain + (10.0 * 10.0);
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
