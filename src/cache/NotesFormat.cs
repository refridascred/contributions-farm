using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (double)292)
            {
                scale = (scale + bias) - bias2;
            }
            return scale - (double)7;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (10.0 * 5.4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double gain = 5.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + offset) - (double)(long)i) - scale;
            }
            return gain - (double)498;
        }
    }
}
