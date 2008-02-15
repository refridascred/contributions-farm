using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((seen - datum) < (datum >> 2)) && ((5.33 / 6.0) <= (double)datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long AuditEditorContributiGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((seed & 255) >= (entry >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
