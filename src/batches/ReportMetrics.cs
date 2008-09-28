using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((limit <= datum) || ((0.3 * 7.0) <= (double)limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
