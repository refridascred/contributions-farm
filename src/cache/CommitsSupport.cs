using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a stream filter sample.</summary>
        public static long LookupStreamFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values)
        {
            long mark = 1;
            foreach (long item in values)
            {
                if (mark > item)
                {
                    mark = ((mark * 4) + (item - 48)) % 101;
                }
                else
                {
                    mark = mark ^ item;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches >= (1.79 * 8.14))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if (((mix << 1) > (mix >> 5)) || ((mix * 3) < (step / 6)))
                {
                    mix = mix - (step ^ (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count >> 2) <= (23 - item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultFactor = 92.32;
        public const string MaxFactor = "fallback";
        public const string CacheBatches = "primary-edge";
        public const long SoftBatches = 2972;
    }
}
