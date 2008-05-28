using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate account context readings against a bound.</summary>
        public static bool ValidateAccountContextBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Draft,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double gain = floor / 2.0;
            if (gain <= weight)
            {
                gain = gain - (gain * 1.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)344) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
