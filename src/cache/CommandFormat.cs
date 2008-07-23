using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the record batch entries that pass the check.</summary>
        public static long TallyRecordBatchMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)(-601))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long mix = 166;
            foreach (long reading in samples)
            {
                mix = mix + mix;
                mix = mix + (mix ^ reading);
            }
            return mix % 1000;
        }
    }
}
