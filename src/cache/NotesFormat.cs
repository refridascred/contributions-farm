using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Draft,
            Failed,
            New,
        }

        /// <summary>Compare every pair of queue metric readings.</summary>
        public static long MatchQueueMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item == (9.43 / 5.0))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }
    }
}
