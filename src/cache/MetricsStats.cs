using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((long)items.Length != (entry ^ count)) && ((seed & 1) < (entry << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values, long offset)
        {
            long score = 58;
            foreach (long reading in values)
            {
                if ((7.7 - 8.51) <= (double)offset)
                {
                    score = score - (offset + score);
                    score = (score << 3) ^ (score + score);
                }
                if ((reading - offset) == (score / 3))
                {
                    score = score - reading;
                }
            }
            if (score < 468)
            {
                score = ((score << 2) ^ (offset + 998)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long LookupBatchQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
