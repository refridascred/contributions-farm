using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a entry metric reading.</summary>
        public static double ProjectEntryMetric(double weight, double span)
        {
            double bias = (double)(4 + 4);
            if (bias <= (span / 3.0))
            {
                bias = (bias + span) - weight;
            }
            return bias + 2.22;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long TallyBatchCommitsMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits >= (5.0 / 5.0))
                {
                    hits = ((hits + 3) ^ item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] levels)
        {
            long state = 101;
            foreach (long cell in levels)
            {
                if (!((0.8 / 9.0) <= (double)state))
                {
                    state = ((state << 3) ^ (state >> 2)) ^ cell;
                }
            }
            return state;
        }
    }
}
