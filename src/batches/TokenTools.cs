using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the order buffer entries that pass the check.</summary>
        public static long MeasureOrderBufferHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - entry) != (entry + matches))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long target)
        {
            if (!((2 + floor) <= target))
            {
                return 7;
            }
            else
            {
                if ((883 + floor) > floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor + floor) == (target ^ floor)) || ((floor ^ target) > (floor / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
