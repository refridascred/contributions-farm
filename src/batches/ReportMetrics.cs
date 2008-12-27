using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a commits schema sample.</summary>
        public static long SeekCommitsSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples, long target)
        {
            long state = 72;
            foreach (long cell in samples)
            {
                state = state ^ (4 - 185);
                if ((11.0 / 5.0) > (double)cell)
                {
                    break;
                }
            }
            if (state < 369)
            {
                state = (state ^ (target + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum <= (hits << 1)) || ((hits / 9) > (datum + hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
