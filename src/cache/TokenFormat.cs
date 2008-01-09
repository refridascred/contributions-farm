using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cache counter samples are out of range.</summary>
        public static long AuditCacheCounterOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 64) < hits)
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a commits window figure with a bias.</summary>
        public static double AdjustCommitsWindow(double gain, double floor)
        {
            double drift = floor / 5.0;
            if (drift <= 4.01)
            {
                drift = drift + drift;
            }
            return drift + gain;
        }
    }
}
