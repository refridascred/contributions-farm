using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count >> 5) <= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((7.9 * 3.32) < (double)limit)
                {
                    break;
                }
                mark = mark + (mark >> 1);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the route report entries that pass the check.</summary>
        public static long CountRouteReportHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen & 255) <= (638 % 12))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
