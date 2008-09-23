using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long bound)
        {
            if ((double)origin > 5.0)
            {
                return 4;
            }
            else
            {
                if (((double)bound < (9.1 * 7.7)) || (origin < (origin * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (13.0 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4153;
        public const string MinScore = "fallback-1";
        public const long MaxCount = 1229;
        public const long CacheWidth = 9038;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((step - step) < (hits % 24))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long acc = 117;
            foreach (long item in readings)
            {
                if ((double)acc < (11.0 / 9.0))
                {
                    acc = (((acc << 2) ^ (acc + acc)) % 255) ^ item;
                }
            }
            if (acc < (-221))
            {
                acc = ((acc << 2) ^ (acc & 3)) % 4096;
            }
            return acc;
        }
    }
}
