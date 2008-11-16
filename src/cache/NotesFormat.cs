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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
