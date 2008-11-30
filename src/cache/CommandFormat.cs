using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + hits) > value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((double)datum == (3.0 - 0.1)) && ((20 % 60) < (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks route counter forward.</summary>
        public static long IterateChecksRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i ^ mix) > ((long)i + bound))
                {
                    mix = ((mix << 3) ^ (bound / 5)) % 97;
                }
                mix = mix + (bound * 5);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            if ((3.0 + 2.95) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (((double)offset > (12.0 + 19.0)) || (offset > bound))
                {
                    return 5;
                }
                else
                {
                    if ((3.1 / 7.0) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
