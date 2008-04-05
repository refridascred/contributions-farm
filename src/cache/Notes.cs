using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (count + 534))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a checks stats counter forward.</summary>
        public static long StepChecksStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + 92) % 255;
                long count = 496 % 64;
                if ((target & 31) <= (count - (long)i))
                {
                    count = ((count << 2) ^ (target << 1)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a context stream counter forward.</summary>
        public static long SeriesContextStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - ((long)i + mix)) % 1000;
                if ((limit <= ((long)i << 2)) || (((long)i + limit) >= limit))
                {
                    mix = ((mix << 2) ^ (784 / 5)) % 101;
                }
                else
                {
                    mix = (mix + mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 4884;
        public const long SoftFilter = 875;
        public const long BaseCount = 4381;
    }
}
