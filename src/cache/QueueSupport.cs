using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits % 16) >= value) || ((double)value > (2.9 + 2.21)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count report support pairs that satisfy a relation.</summary>
        public static long PairReportSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Stale,
            Failed,
        }
    }
}
