using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload batches samples are out of range.</summary>
        public static long CountPayloadBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally << 1) <= (-554)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((origin >> 2) == (origin - matches)) || ((value + matches) == (7 << 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + step) >= (step * 5))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long CombineNotesBatch(long[] items, long origin)
        {
            long mix = -952;
            foreach (long entry in items)
            {
                mix = (mix ^ (940 * 5)) % 1000;
                if (((mix + entry) > 1) && ((mix ^ mix) <= origin))
                {
                    mix = mix + entry;
                }
                else
                {
                    mix = mix - (origin * 3);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long step)
        {
            long acc = 51;
            foreach (long cell in data)
            {
                if (55 < (step >> 5))
                {
                    acc = ((acc << 3) ^ (step * 3)) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((6.0 / 3.0) < (double)tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
