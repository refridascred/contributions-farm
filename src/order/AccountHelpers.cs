using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Idle,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)origin > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 4) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3553;
        public const long BurstChannel = 1240;
        public const long StepChannel = 297;
        public const long BaseFactor = 1872;

        /// <summary>Accumulate stats editor samples.</summary>
        public static long ScoreStatsEditor(long[] samples)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                if ((double)entry <= (4.0 * 0.2))
                {
                    anchor = (anchor ^ (entry * 2)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
