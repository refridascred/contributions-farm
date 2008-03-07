using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((double)hits > (double)datum))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long seed)
        {
            if ((double)seed <= (7.4 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((seed > (floor + seed)) && ((floor ^ floor) >= (floor / 8)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + floor) < 40)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long mix = 59;
            foreach (long item in samples)
            {
                if ((double)mix == (double)item)
                {
                    mix = ((mix << 2) ^ (41 - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((double)value < (4.05 / 7.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token queue sample.</summary>
        public static long FindTokenQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
