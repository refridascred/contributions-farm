using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool ValidateReportBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a account metrics counter forward.</summary>
        public static long SeriesAccountMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                long delta = 4;
                if ((0.2 + 3.0) == (double)delta)
                {
                    mix = ((mix * 2) + delta) % 255;
                }
                if (!((origin >> 4) != (mix % 5)))
                {
                    mix = (mix - (339 & 15)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = 968;
            foreach (long item in samples)
            {
                mark = ((mark * 4) + (item & 1)) % 97;
            }
            return mark;
        }
    }
}
