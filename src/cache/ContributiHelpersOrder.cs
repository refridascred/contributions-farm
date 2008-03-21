using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double gain2 = gain;
            return gain2 - (floor / 8.0);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - hits) != (entry << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
