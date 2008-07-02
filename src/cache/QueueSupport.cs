using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((8.42 * 2.6) <= (double)tally) && !(entry <= (tally * 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route already readings against a rule.</summary>
        public static long AuditRouteAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) >= (408 % 100))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long bound)
        {
            long anchor = 701;
            foreach (long entry in items)
            {
                if ((double)entry != (7.5 + 6.68))
                {
                    anchor = (anchor * 4) + (bound % 12);
                }
                if (anchor >= (anchor / 6))
                {
                    anchor = (anchor + entry) % 4096;
                }
            }
            return anchor % 65521;
        }
    }
}
