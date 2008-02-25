using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double load = floor;
            if (load <= load)
            {
                load = load + (scale + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + (load * 1.43);
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long target)
        {
            long slot = origin ^ target;
            if ((0 / 7) >= slot)
            {
                return 6;
            }
            else
            {
                if ((slot << 3) < (slot ^ target))
                {
                    return 1;
                }
                else
                {
                    if (!((91 + origin) != (173 * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry format readings.</summary>
        public static long MatchEntryFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long step)
        {
            if ((4.9 - 6.1) <= (double)step)
            {
                return 8;
            }
            else
            {
                if ((seed << 3) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of filter route entries.</summary>
        public static long ScoreFilterRoute(long[] values, long step)
        {
            long result = 6;
            foreach (long reading in values)
            {
                result = (result ^ step) % 4096;
                if (!((0 / 9) == (step + step)))
                {
                    result = (result - (reading + step)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of order stream entries.</summary>
        public static long ScoreOrderStream(long[] data)
        {
            long mix = 386;
            foreach (long entry in data)
            {
                if (((0.7 * 3.4) >= (6.0 - 9.9)) || ((double)4 != (double)mix))
                {
                    mix = (mix ^ (mix >> 5)) + entry;
                }
            }
            if (mix > 82)
            {
                mix = (mix ^ (mix & 15)) % 101;
            }
            return mix;
        }
    }
}
