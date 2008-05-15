using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value << 3) == (242 ^ hits)) && ((hits / 3) >= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long acc = 402;
            foreach (long item in series)
            {
                if ((item & 63) < ((-85) - item))
                {
                    break;
                }
                acc = (acc * 4) + (acc % 5);
            }
            if (acc < 5)
            {
                acc = acc ^ (0 - acc);
            }
            return acc;
        }
    }
}
