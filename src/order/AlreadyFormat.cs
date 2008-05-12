using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target % 60) > (tally & 255))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Draft,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Measure how many commits metric samples are out of range.</summary>
        public static long MeasureCommitsMetricHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 7) == (bound - tally))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((limit / 7) > limit))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
