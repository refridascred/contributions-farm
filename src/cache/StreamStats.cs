using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value >= (long)values.Length) || ((double)count < (double)origin))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((tally % 12) >= (tally % 8)) && (tally < (entry & 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc ^ (seed << 1)) % 97) ^ cell;
            }
            if (acc < 60)
            {
                acc = acc ^ (143 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
