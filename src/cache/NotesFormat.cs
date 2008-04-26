using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stats githubfarm input into a small class.</summary>
        public static long RankStatsGithubfarm(long target, long origin)
        {
            if ((double)323 >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((4.1 + 8.02) > (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 3) < (origin - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry < (entry & 7)) && ((entry + entry) < entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double bias = (double)(175 & 1);
            if (bias > span)
            {
                bias = bias + weight;
            }
            return bias + weight;
        }
    }
}
