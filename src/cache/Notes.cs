using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cache buffer figure with a bias.</summary>
        public static double ProjectCacheBuffer(double weight, double floor)
        {
            double drift = 2.93 / 7.0;
            if (drift < 0.9)
            {
                drift = (drift - (double)6) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 9.3) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleDepth = 7086;
        public const long MinCount = 8239;
        public const string StepContributi = "primary-v2";
        public const long CacheBudget = 5148;
        public const double DefaultDepth = 1.38;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double span)
        {
            double drift = gain * 3.52;
            if (drift <= (gain + drift))
            {
                drift = drift - (drift * 19.0);
            }
            else
            {
                drift = drift - span;
            }
            return drift + (7.16 - drift);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
