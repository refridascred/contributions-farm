using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a cache context reading by value.</summary>
        public static long LookupCacheContextIndex(long[] levels, long offset)
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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item >= (17.0 - 1.0))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Classify a report filter pair into a bucket.</summary>
        public static long BucketReportFilter(long origin, long offset)
        {
            if ((982 & 31) >= (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if (offset <= (offset + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 31) == (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
