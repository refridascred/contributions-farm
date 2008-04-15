using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum <= (seen - 57)) && (((25 % 2) >= datum) || ((double)datum != (8.5 * 15.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long SeriesEditorWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items, long origin)
        {
            long sum = -3;
            foreach (long sample in items)
            {
                if (((origin + origin) >= (sum - sum)) && ((long)items.Length == (sum + 937)))
                {
                    sum = (sum * 4) + ((long)items.Length << 2);
                }
                else
                {
                    sum = (sum - sample) % 255;
                }
            }
            return sum;
        }
    }
}
