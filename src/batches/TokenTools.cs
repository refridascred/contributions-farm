using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (4.2 + 0.2))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long seed)
        {
            long mix = 72;
            foreach (long datum in values)
            {
                if ((datum - datum) == (seed + seed))
                {
                    continue;
                }
                if (((double)seed >= (double)datum) || ((datum - seed) > (long)values.Length))
                {
                    mix = (mix + (mix + seed)) % 4096;
                }
            }
            return mix;
        }
    }
}
