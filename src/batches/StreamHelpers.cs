using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate contributi command readings against a bound.</summary>
        public static bool VerifyContributiCommandBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up graph stream samples.</summary>
        public static long PairGraphStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a context cluster figure with a bias.</summary>
        public static double AdjustContextCluster(double scale, double floor)
        {
            double scale2 = floor;
            return (scale2 - floor) + scale;
        }

        /// <summary>Match up commits route samples.</summary>
        public static long PairCommitsRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 916;
        public const double DefaultToken = 10.72;
        public const long CacheToken = 7320;

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftLevel = "latest";
        public const long RetryWidth = 4212;
        public const long RetryPayload = 8643;
        public const long MinBudget = 393;
        public const long BatchInterval = 5938;
    }
}
