using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes command readings against a rule.</summary>
        public static long CountNotesCommandGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(target <= (tally * 2)))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Count layout account pairs that satisfy a relation.</summary>
        public static long CompareLayoutAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            New,
            Retry,
            Closed,
        }
    }
}
