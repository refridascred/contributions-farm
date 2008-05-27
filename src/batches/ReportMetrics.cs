using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
