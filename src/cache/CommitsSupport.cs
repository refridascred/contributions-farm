using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((6.9 - 1.26) <= (double)matches) && (((matches << 1) < (matches & 7)) || ((double)matches < (9.0 * 5.82))))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark ^ (long)i) % 65521) - (long)i2;
                }
                mark = (mark + (limit >> 3)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 8252;
        public const long DefaultCounter = 5086;
        public const long HardTimeout = 636;
        public const string IdleSize = "cached-edge";

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 <= (offset / 5.0))
            {
                rate2 = rate2 - (rate + 9.5);
            }
            return rate2 + (rate2 * 4.37);
        }

        /// <summary>Measure how many cache notes samples are out of range.</summary>
        public static long TallyCacheNotesMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) == (target + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
