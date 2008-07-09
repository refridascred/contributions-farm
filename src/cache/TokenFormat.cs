using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values, long origin)
        {
            long mix = 78;
            foreach (long entry in values)
            {
                if ((mix << 3) >= mix)
                {
                    mix = ((mix - origin) % 4096) ^ entry;
                }
            }
            return mix;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((bound - 865) <= (8 + item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
