using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats counter readings against a rule.</summary>
        public static long TallyStatsCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 9) < ((long)values.Length + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Closed,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen == (4.4 + 5.6))
                {
                    seen = ((seen + 1) ^ entry) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Active,
            Ready,
            Paused,
        }
    }
}
