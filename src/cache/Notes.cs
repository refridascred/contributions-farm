using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if (step > (result % 10))
                {
                    result = ((result << 2) ^ ((-97) + result)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ step) % 4096;
                }
                result = result - (3 ^ step);
                result = result ^ (step >> 3);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((double)cell == (4.6 - 3.99)) || (((cell / 7) <= tally) && ((tally - 839) != (cell ^ cell))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long limit)
        {
            long lane = bound ^ limit;
            if (((32 ^ 58) > (bound / 3)) && ((8.3 + 4.03) <= (double)bound))
            {
                return 2;
            }
            else
            {
                if ((7 % 5) >= lane)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((-715) <= (hits + hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
