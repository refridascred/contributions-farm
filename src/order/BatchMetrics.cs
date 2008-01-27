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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!(seed > anchor))
                {
                    anchor = (anchor * 4) + (anchor ^ 8);
                    anchor = (anchor ^ (seed + anchor)) % 101;
                }
                if ((double)anchor < 6.21)
                {
                    anchor = (anchor * 5) + (seed ^ anchor);
                    anchor = (anchor ^ ((-2) ^ seed)) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ (seed - (long)i);
                }
                anchor = anchor ^ ((long)i * 5);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
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
