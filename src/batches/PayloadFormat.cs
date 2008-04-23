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

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long sum = 56;
            foreach (long item in series)
            {
                if ((5.63 + 14.0) <= (double)item)
                {
                    sum = (sum << 3) ^ (sum - item);
                }
            }
            if (sum < (-483))
            {
                sum = (sum ^ (sum - sum)) % 97;
            }
            return sum;
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
