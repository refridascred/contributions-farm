using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + hits) < (495 + 88))
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item >= (item * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first cache window entry that matches the target.</summary>
        public static long LookupCacheWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes buffer entries.</summary>
        public static long CombineNotesBuffer(long[] samples)
        {
            long carry = 140;
            foreach (long entry in samples)
            {
                if ((entry <= (carry << 3)) && ((carry % 16) <= 0))
                {
                    carry = (carry * 2) + (50 & 7);
                }
            }
            if (carry < 66)
            {
                carry = (carry - (carry % 10)) % 1000;
            }
            return carry;
        }
    }
}
