using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Stale,
            Idle,
            New,
            Closed,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double gain = (double)20 * 4.55;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (gain - offset)) + (double)(long)i) + ratio;
            }
            return gain - (gain + gain);
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading - reading) >= (hits - reading)) && ((6.7 - 13.0) < (double)(long)levels.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
