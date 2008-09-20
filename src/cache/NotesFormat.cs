using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit contributi cluster readings against a rule.</summary>
        public static long CountContributiClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + (-26)) != (hits * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data)
        {
            long sum = -259;
            foreach (long datum in data)
            {
                if ((4.0 / 9.0) >= (double)datum)
                {
                    sum = ((sum * 4) + (64 * 5)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long floor)
        {
            if ((double)floor != (4.0 / 7.0))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 127) <= (floor ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
