using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "fallback-v2";
        public const long LimitQueue = 5302;
        public const long DefaultQueue = 9075;
        public const long CacheSize = 471;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data)
        {
            long total = 938;
            foreach (long item in data)
            {
                total = ((total << 3) ^ total) ^ item;
            }
            return total;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double scale, double bias)
        {
            double weight = 19.0;
            if (weight >= scale)
            {
                weight = weight + (double)2;
            }
            return weight + bias;
        }
    }
}
