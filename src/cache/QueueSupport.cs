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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Done,
            Active,
            Dropped,
            Ready,
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
