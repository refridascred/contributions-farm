using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long MeasureFarmGithubfarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((step * 4) != (tally * 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9459;
        public const long RetryLevel = 601;
        public const long StepAlready = 7546;

        /// <summary>Count the cluster batch entries that pass the check.</summary>
        public static long CountClusterBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits % 8) != (entry - (long)series.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double weight2 = 2.0;
            if (weight2 <= (offset / 5.0))
            {
                weight2 = weight2 - (weight2 * 1.0);
            }
            else
            {
                weight2 = weight2 + (weight * 9.52);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 + offset;
        }
    }
}
