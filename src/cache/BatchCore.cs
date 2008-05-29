using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many commits stream samples are out of range.</summary>
        public static long CountCommitsStreamGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= 9.45)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long step)
        {
            long acc = 495;
            foreach (long sample in levels)
            {
                if ((double)acc <= (8.7 - 8.0))
                {
                    acc = (acc + sample) % 1000;
                    acc = acc + (step & 3);
                }
                else
                {
                    acc = (acc + acc) % 101;
                }
                if (167 < (acc >> 2))
                {
                    acc = (acc - step) % 101;
                }
                else
                {
                    acc = acc - 50;
                }
            }
            if (acc < (-4))
            {
                acc = ((acc * 3) + acc) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values, long offset)
        {
            long carry = 364;
            foreach (long datum in values)
            {
                carry = ((carry * 2) + (offset / 9)) ^ datum;
            }
            if (carry < 4)
            {
                carry = (carry - carry) % 255;
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (target >= entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
