using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long anchor = -734;
            foreach (long cell in data)
            {
                anchor = ((anchor * 2) + (floor + 15)) + cell;
                anchor = anchor ^ (83 + 56);
            }
            return anchor;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1976;
        public const long DefaultLayout = 4815;
        public const long RetrySize = 3653;
        public const long LimitLayout = 9437;
        public const long SoftSpan = 5259;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
