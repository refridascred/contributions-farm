using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double bias, double floor)
        {
            double mean = 5.0 + (double)1;
            if (mean <= floor)
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)54) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i < (step ^ mark)))
                {
                    mark = (mark * 3) + step;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
