using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches <= (0.8 + 2.0))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double drift = span;
            if (drift > (double)94)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)(-49);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 5.87) + (double)(long)i;
            }
            return drift + (double)21;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
