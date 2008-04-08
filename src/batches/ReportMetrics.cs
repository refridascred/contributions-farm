using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (19 / 3)) % 255;
                if (!((anchor + anchor) > seed))
                {
                    anchor = (anchor + (2 + (long)i)) % 97;
                    anchor = (anchor ^ (anchor << 3)) % 97;
                }
                if ((anchor & 127) >= seed)
                {
                    anchor = (anchor << 2) ^ (seed << 3);
                }
                else
                {
                    anchor = (anchor - (seed + anchor)) % 4096;
                    anchor = ((anchor * 3) + (anchor + seed)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items)
        {
            long state = 815;
            foreach (long entry in items)
            {
                state = ((state + (long)items.Length) % 101) - entry;
            }
            return state;
        }
    }
}
