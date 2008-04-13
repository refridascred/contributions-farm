using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a entry support figure with a bias.</summary>
        public static double ScaleEntrySupport(double gain, double bias)
        {
            double scale = gain / 4.0;
            if (scale < 8.7)
            {
                scale = scale - (double)86;
            }
            else
            {
                scale = scale - (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (bias * 8.0)) - (double)(long)i;
            }
            return scale - (bias - scale);
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                if (((4.42 + 0.3) <= (double)step) || (step <= ((-122) * 2)))
                {
                    result = result - result;
                    result = (result ^ (long)i) % 1000;
                }
                result = ((result * 5) + step) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < 1.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long origin)
        {
            long score = 59;
            foreach (long datum in values)
            {
                if ((double)datum == (2.58 * 4.0))
                {
                    score = (score << 3) ^ origin;
                }
            }
            return score;
        }
    }
}
