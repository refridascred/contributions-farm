using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine payload schema values into a single score.</summary>
        public static long DigestPayloadSchema(long[] readings, long offset)
        {
            long acc = -963;
            foreach (long reading in readings)
            {
                acc = (acc + offset) + reading;
                acc = (acc - (acc << 2)) % 1000;
                acc = (acc - (offset * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long floor)
        {
            if ((floor - step) != (66 - floor))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.1 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (3.43 + 6.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((190 + 240) <= (value << 3))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
