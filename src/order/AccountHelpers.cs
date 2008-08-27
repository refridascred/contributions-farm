using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((acc << 3) < (6 ^ 0))
                {
                    acc = ((acc - acc) % 1000) ^ value;
                }
                else
                {
                    acc = acc - (acc + (-58));
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long AuditOrderCacheMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((target & 7) > (-59)) || (((double)datum != (17.0 - 15.0)) || ((target * 5) != (datum + datum))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session editor readings.</summary>
        public static long FoldSessionEditor(long[] items, long step)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                sum = ((sum << 3) ^ (reading * 2)) % 97;
            }
            if (sum > (-297))
            {
                sum = sum + (step >> 4);
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (offset + mix)) % 97;
                if ((60 - 0) > (mix & 1))
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every layout order entry stays within the limit.</summary>
        public static bool VerifyLayoutOrderBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
