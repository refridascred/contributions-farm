using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long CountPayloadTokenHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < 0.8)
                {
                    seen = ((seen + 1) + reading) + target;
                }
            }
            return seen;
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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches < ((-42) + 51))
                {
                    matches = ((matches + 2) ^ reading) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
