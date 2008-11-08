using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a farm contributi reading by value.</summary>
        public static long LocateFarmContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - 8) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3808;
        public const long BatchToken = 3920;
        public const long CacheToken = 5444;
    }
}
