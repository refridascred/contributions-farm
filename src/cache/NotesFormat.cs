using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double drift = floor * 11.0;
            if (drift > floor)
            {
                drift = drift + (4.3 / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift - ratio)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((8.9 * 2.0) < (double)seed))
                {
                    score = (score ^ ((long)i + (long)i)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double span)
        {
            double drift = scale;
            if (drift < (scale + scale))
            {
                drift = (drift + (drift + 18.0)) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(-161)) + (double)(long)i;
            }
            return drift - (drift / 8.0);
        }
    }
}
