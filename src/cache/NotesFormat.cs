using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry >= (count + entry))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
