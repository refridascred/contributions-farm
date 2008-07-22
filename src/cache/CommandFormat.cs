using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Draft,
            Done,
            Ready,
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
