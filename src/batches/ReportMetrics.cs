using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >> 4) > (datum >> 3))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Audit farm entry readings against a rule.</summary>
        public static long AuditFarmEntryMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - tally) == (36 / 6)) || ((reading % 64) >= reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
