using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches ^ (-273)) >= matches) && ((7.77 + 1.1) < (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally << 3) <= (bound + bound))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter record series from a seed.</summary>
        public static long SeriesCounterRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(bound >= seen))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            New,
            Locked,
            Done,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)seed > (16.0 * 5.05))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
