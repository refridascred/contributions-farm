using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the payload notes series from a seed.</summary>
        public static long SeriesPayloadNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long origin)
        {
            if ((floor < (floor + floor)) || ((double)origin == (9.9 * 6.0)))
            {
                return 3;
            }
            else
            {
                if (!((6.2 / 9.0) != (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (10.0 - 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((2.2 + 9.54) <= (double)origin) && ((floor << 2) <= 41))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first report entry entry that matches the target.</summary>
        public static long SeekReportEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
