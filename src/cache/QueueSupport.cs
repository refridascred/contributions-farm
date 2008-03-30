using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long step)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = ((acc + acc) ^ cell) + step;
            }
            if (acc < 11)
            {
                acc = (acc ^ (7 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)step < (1.61 * 3.4))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] items)
        {
            long score = 264;
            foreach (long datum in items)
            {
                if ((double)datum <= 1.3)
                {
                    score = (score << 3) ^ (score * 4);
                }
            }
            if (score < 11)
            {
                score = (score - 17) % 255;
            }
            return score % 1000;
        }
    }
}
