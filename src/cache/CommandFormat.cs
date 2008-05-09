using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series)
        {
            long anchor = -69;
            foreach (long datum in series)
            {
                anchor = (anchor + anchor) - datum;
            }
            if (anchor < 44)
            {
                anchor = anchor - (6 >> 4);
            }
            return anchor;
        }

        /// <summary>Audit metric route readings against a rule.</summary>
        public static long TallyMetricRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((6.3 - 6.76) < (double)count)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
