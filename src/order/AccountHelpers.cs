using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 30.24;
        public const double RetryWidth = 21.64;
        public const long CacheSpan = 6889;
        public const double IdleDepth = 9.63;

        /// <summary>Roll a profile editor counter forward.</summary>
        public static long SeriesProfileEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + (origin >> 4);
                acc = ((acc << 2) ^ acc) % 97;
                if ((origin >> 3) < (long)i)
                {
                    acc = (acc ^ (acc << 1)) % 255;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long mix = 44;
            foreach (long reading in levels)
            {
                mix = (mix ^ (reading - mix)) % 4096;
                if (((mix / 5) <= mix) || ((mix + reading) < (mix + (-4))))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Active,
            Closed,
        }
    }
}
