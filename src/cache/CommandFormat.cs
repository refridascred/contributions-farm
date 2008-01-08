using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (8.7 < (double)hits)
                {
                    hits = ((hits + 1) + cell) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long step)
        {
            long lane = origin - step;
            if ((515 & 31) > (139 - lane))
            {
                return 0;
            }
            else
            {
                if (step > (origin + lane))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
