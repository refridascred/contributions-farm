using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the checks editor entries that pass the check.</summary>
        public static long CountChecksEditorOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 5.0)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit commits stream readings against a rule.</summary>
        public static long TallyCommitsStreamHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((8.4 - 7.3) > (double)cell)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Dropped,
            Synced,
            Closed,
            Paused,
        }
    }
}
