using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < (3 - tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long score = 7;
            foreach (long reading in samples)
            {
                if (((8.0 + 6.51) < (double)score) && ((848 << 2) >= (reading << 1)))
                {
                    score = (score - reading) % 4096;
                }
            }
            if (score > 778)
            {
                score = (score - score) % 4096;
            }
            return score;
        }
    }
}
