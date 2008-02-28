using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count editor command pairs that satisfy a relation.</summary>
        public static long OverlapEditorCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items, long origin)
        {
            long total = -355;
            foreach (long entry in items)
            {
                total = (total ^ 8) % 1000;
                if (origin < (origin - entry))
                {
                    total = ((total * 4) + total) % 255;
                }
                else
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total > 834)
            {
                total = total + (total << 3);
            }
            return total;
        }
    }
}
