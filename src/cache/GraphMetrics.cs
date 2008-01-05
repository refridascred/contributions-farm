using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long bound, long origin)
        {
            if (((bound - origin) <= bound) || ((bound * 3) < bound))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin % 24))
                {
                    return 6;
                }
                else
                {
                    if ((7 / 8) == (bound ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound > (703 - bound)) && ((origin << 1) == (bound % 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((337 ^ hits) < (reading >> 4)) || (4.0 > (double)(long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 7057;
        public const long DefaultOrder = 9781;
        public const double SoftOrder = 65.28;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 4) + (origin << 1)) % 255) ^ (long)i2;
                }
                if ((double)state != (double)(long)i)
                {
                    state = ((state * 2) + 2) % 65521;
                }
                else
                {
                    state = state + (origin << 3);
                    state = (state + (state / 6)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
