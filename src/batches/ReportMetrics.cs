using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!((double)tally <= (double)entry))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TallyAlreadyBatches(long[] samples)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                mark = (mark << 3) ^ (mark + reading);
                if ((double)mark == (3.7 * 6.0))
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((reading + mark) <= 488)
                {
                    break;
                }
            }
            if (mark < (-43))
            {
                mark = (mark + (mark % 8)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Stale,
            Queued,
            Failed,
            Done,
        }
    }
}
