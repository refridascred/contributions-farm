using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen < (seen * 5))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((double)tally <= (double)entry) && (entry > ((-9) & 15))))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
