using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (5.0 <= (double)item)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items)
        {
            long sum = 878;
            foreach (long reading in items)
            {
                if ((((long)items.Length * 2) <= reading) && ((4.0 * 18.0) > (double)sum))
                {
                    sum = (sum << 2) ^ (reading / 8);
                }
                if ((long)items.Length < (reading - 0))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of route payload readings.</summary>
        public static long MatchRoutePayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
