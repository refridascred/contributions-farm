using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 60.06;
        public const string BurstRecord = "stable";
        public const long BaseSize = 7699;
        public const long BatchRatio = 8147;
        public const long CacheRecord = 8953;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long bound)
        {
            long prev = floor ^ bound;
            if (((double)prev >= (6.0 + 7.43)) || ((double)floor < (double)bound))
            {
                return 4;
            }
            else
            {
                if ((floor + 6) >= (prev & 127))
                {
                    return 6;
                }
                else
                {
                    if (!((488 & 3) >= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first command metric entry that matches the target.</summary>
        public static long LocateCommandMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long CombineAccountCommand(long[] data, long target)
        {
            long acc = 5;
            foreach (long cell in data)
            {
                acc = (((acc * 2) + ((long)data.Length - target)) % 1000) - cell;
            }
            if (acc > 939)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
