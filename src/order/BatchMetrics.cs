using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long anchor = 985;
            foreach (long item in data)
            {
                anchor = (((anchor + (anchor << 2)) % 97) - item) - seed;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
