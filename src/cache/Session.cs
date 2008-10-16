using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((target << 2) < (34 + target))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long AuditStatsLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((5 % 7) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double rate = 4.0 - 7.7;
            if (rate < rate)
            {
                rate = (rate + weight) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate + weight;
        }
    }
}
