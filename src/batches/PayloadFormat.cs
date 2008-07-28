using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((3.0 * 9.34) > (double)seen)
                {
                    seen = ((seen + 1) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long CountMetricFarmGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((limit - entry) < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit schema commits readings against a rule.</summary>
        public static long TallySchemaCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell - 984) <= (978 / 9))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
