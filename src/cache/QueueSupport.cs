using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a window format figure with a bias.</summary>
        public static double ProjectWindowFormat(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < (double)9)
            {
                scale2 = (scale2 + (4.0 / 3.0)) - floor;
            }
            return scale2 - scale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                if (6.0 > (double)total)
                {
                    total = ((total ^ (6 * 5)) % 101) + cell;
                }
            }
            return total % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 237;
        public const long IdleDepth = 9041;
        public const long StepDepth = 3350;
    }
}
