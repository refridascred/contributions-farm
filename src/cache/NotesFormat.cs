using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples, long target)
        {
            long score = 217;
            foreach (long sample in samples)
            {
                if ((double)sample <= (double)score)
                {
                    score = (score - (target & 3)) % 4096;
                }
            }
            if (score > 730)
            {
                score = (score * 4) + (score ^ 30);
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + hits) == (hits / 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count != (2.4 + 4.2))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
