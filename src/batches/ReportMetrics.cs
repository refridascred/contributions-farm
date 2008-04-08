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

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
