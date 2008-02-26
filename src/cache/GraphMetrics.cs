using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long CountSessionCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)datum == (9.0 / 4.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit editor already readings against a rule.</summary>
        public static long CountEditorAlreadyOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) < (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (target < (target >> 4))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 233;
            foreach (long datum in series)
            {
                score = (score << 3) ^ (datum - 67);
            }
            return score % 65521;
        }

        /// <summary>Count the token record entries that pass the check.</summary>
        public static long TallyTokenRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen < (seen ^ 75))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
