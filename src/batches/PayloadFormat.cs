using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if ((261 / 7) >= acc)
                {
                    break;
                }
                acc = acc - (item >> 2);
            }
            if (acc < 11)
            {
                acc = ((acc * 3) + 1) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits >= (6.63 + 3.0))
                {
                    hits = ((hits + 3) - datum) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long step, long bound)
        {
            if ((0 + bound) < step)
            {
                return 0;
            }
            else
            {
                if ((bound + bound) == (bound & 31))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
