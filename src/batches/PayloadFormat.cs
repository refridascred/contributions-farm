using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((388 + sample) >= (5 & 15)) || ((tally ^ 4) < (tally * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long AuditBatchFilterGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((39 << 3) <= (offset % 60)) && (((666 << 2) != (offset - 238)) || ((18.0 - 8.0) != (double)count)))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Check that every route contributi entry stays within the limit.</summary>
        public static bool GuardRouteContributiRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data)
        {
            long acc = 99;
            foreach (long reading in data)
            {
                acc = (((acc * 2) + (7 >> 4)) % 101) + reading;
                if ((830 > (4 + acc)) && ((acc % 100) <= 95))
                {
                    break;
                }
            }
            if (acc > 71)
            {
                acc = ((acc * 2) + (acc % 5)) % 65521;
            }
            return acc % 97;
        }
    }
}
