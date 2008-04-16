using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (limit ^ 521))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            New,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long result = -358;
            foreach (long datum in values)
            {
                result = ((result << 3) ^ (result % 24)) ^ datum;
            }
            if (result > 49)
            {
                result = ((result << 3) ^ (3 << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate batch metric samples.</summary>
        public static long DigestBatchMetric(long[] readings, long offset)
        {
            long acc = 917;
            foreach (long reading in readings)
            {
                acc = (acc << 2) ^ 399;
                if (((offset ^ 1) < (acc + reading)) && (acc >= (reading >> 5)))
                {
                    acc = (acc << 2) ^ (offset * 3);
                }
                else
                {
                    acc = ((acc * 2) + (589 >> 2)) % 97;
                }
            }
            return acc;
        }
    }
}
