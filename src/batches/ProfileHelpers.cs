using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i != (2.0 + 5.9))
                {
                    acc = ((acc << 3) ^ (acc * 4)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits * 2) != (item + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1598;
        public const long MaxSize = 8619;
        public const string BatchCounter = "latest-1";

        /// <summary>Accumulate context entry samples.</summary>
        public static long DigestContextEntry(long[] readings)
        {
            long mark = 983;
            foreach (long entry in readings)
            {
                if (((mark >> 2) >= (entry & 127)) || ((entry ^ (-69)) > (entry + entry)))
                {
                    mark = (mark + (mark & 63)) % 255;
                }
            }
            return mark % 1000;
        }
    }
}
