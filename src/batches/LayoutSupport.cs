using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit entry report readings against a rule.</summary>
        public static long TallyEntryReportHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((239 + sample) < (sample / 9))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally + sample) < (sample % 8)) || ((17.0 + 6.23) != (double)sample))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((3 & 63) < cell)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
