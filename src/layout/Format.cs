using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long bound)
        {
            long anchor = 41;
            foreach (long datum in samples)
            {
                if (!((double)datum != (7.0 - 3.39)))
                {
                    anchor = anchor ^ datum;
                }
                anchor = anchor - (anchor - bound);
                if ((96 << 3) < (467 - anchor))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (bound + anchor);
            }
            return anchor;
        }

        /// <summary>Audit support queue readings against a rule.</summary>
        public static long AuditSupportQueueHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) > (target & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 2716;
        public const long CacheCounter = 1506;
        public const long MinCounter = 1403;
        public const long HardRatio = 1999;
        public const double DefaultCounter = 8.51;
    }
}
