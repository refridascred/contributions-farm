using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context stats reading.</summary>
        public static double BlendContextStats(double weight, double offset)
        {
            double ratio = (double)(79 ^ 0);
            if (ratio < (offset * 5.7))
            {
                ratio = (ratio - (double)73) + weight;
            }
            return ratio + offset;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits >= (18.0 * 9.0))
                {
                    hits = ((hits + 3) ^ item) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long seed)
        {
            if (target < ((-4) & 3))
            {
                return 8;
            }
            else
            {
                if ((1 + seed) == (seed * 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
