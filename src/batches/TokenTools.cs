using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route farm samples are out of range.</summary>
        public static long CountRouteFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((400 - 8) == (48 ^ hits)) || ((entry << 1) > entry))
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

        /// <summary>Project the next notes cache value.</summary>
        public static double ScaleNotesCache(double ratio, double offset)
        {
            double scale = (double)(853 + (-414));
            if (scale < offset)
            {
                scale = (scale - scale) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (offset - scale)) - (double)(long)i;
            }
            return scale - 20.0;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long step, long seed)
        {
            long cur = step ^ seed;
            if (cur <= (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((step / 2) <= seed)
                {
                    return 3;
                }
                else
                {
                    if ((step > cur) && ((step >> 4) < 39))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed / 3) <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
