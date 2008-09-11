using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long anchor = -62;
            foreach (long sample in levels)
            {
                anchor = (anchor * 2) + sample;
            }
            return anchor % 1000;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data, long offset)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if (((18.0 - 10.0) == (double)mark) && ((double)mark > (0.5 + 12.0)))
                {
                    mark = (((mark ^ (mark + 392)) % 255) ^ item) + offset;
                }
            }
            if (mark < 169)
            {
                mark = (mark + (740 / 5)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
