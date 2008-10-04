using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the batch editor entries that pass the check.</summary>
        public static long AuditBatchEditorOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches % 8) <= reading)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Failed,
            Closed,
            New,
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
