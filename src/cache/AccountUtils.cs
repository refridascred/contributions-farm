using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double span)
        {
            double scale = span / 2.0;
            if (scale < (scale - bias))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 9.0);
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally <= (483 ^ tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
