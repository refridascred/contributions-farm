using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the cache filter series from a seed.</summary>
        public static long RollCacheFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a counter layout figure with a bias.</summary>
        public static double ScaleCounterLayout(double rate, double floor)
        {
            double drift = rate - rate;
            if (drift <= drift)
            {
                drift = drift - floor;
            }
            return drift + (double)(-2);
        }

        /// <summary>Check that every profile command entry stays within the limit.</summary>
        public static bool CheckProfileCommandRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
