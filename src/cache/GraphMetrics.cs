using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit channel queue readings against a rule.</summary>
        public static long CountChannelQueueMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum < (seed - datum)) || (42 <= (count >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((limit + 849) <= limit)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((limit ^ limit) < sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long limit)
        {
            if ((4.5 - 2.9) > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((13.0 - 0.2) == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
