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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                carry = (carry << 2) ^ entry;
                if ((entry % 8) <= (entry * 2))
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + (carry ^ carry)) % 4096;
            }
            return carry % 97;
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
