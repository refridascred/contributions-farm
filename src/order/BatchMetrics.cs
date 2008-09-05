using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of token editor readings.</summary>
        public static long PairTokenEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes route readings against a rule.</summary>
        public static long MeasureNotesRouteGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally >> 5) < (tally ^ reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((5.5 - 5.16) > (double)entry)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Match up batch command samples.</summary>
        public static long MatchBatchCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
