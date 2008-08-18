using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long ClassifyLayoutCommits(long origin, long seed)
        {
            long step = origin - seed;
            if ((7.34 + 2.9) > (5.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((20 + 17) < (seed + 1)) && ((double)step == (9.93 * 3.0)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + seed) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((step << 3) == (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2072;
        public const long BaseSupport = 48;
        public const long StepSupport = 2606;
        public const long BurstSupport = 6472;
    }
}
