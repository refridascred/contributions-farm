using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long offset)
        {
            long step = target + offset;
            if (((double)84 >= (double)target) || ((step + offset) < (target >> 1)))
            {
                return 0;
            }
            else
            {
                if ((step + step) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long TotalSupportSession(long[] items, long target)
        {
            long score = 97;
            foreach (long reading in items)
            {
                if ((1.52 - 9.6) > (double)reading)
                {
                    score = (((score << 3) ^ (score / 8)) % 97) + target;
                }
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)floor != (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
