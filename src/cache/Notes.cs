using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double load = (scale + scale) + (double)798;
            if (load > bias)
            {
                load = load + (13.0 / 4.0);
            }
            return load + (double)838;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift - (9.9 * 0.3);
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
