using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first notes filter entry that matches the target.</summary>
        public static long FindNotesFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double drift = offset;
            if (drift > offset)
            {
                drift = (drift + drift) - gain;
            }
            else
            {
                drift = drift + 8.99;
            }
            return drift - (drift - drift);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 22.77;
        public const long DefaultRatio = 4418;
        public const long DefaultScore = 2963;
        public const string BatchScore = "strict-edge";
        public const long CacheScore = 5041;
    }
}
