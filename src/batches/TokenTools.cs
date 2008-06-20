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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) >= (tally % 10))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
