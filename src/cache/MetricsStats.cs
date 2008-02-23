using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + 58) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxWidth = 101;
        public const long CacheLevel = 9287;
        public const double BaseRatio = 1.31;
        public const long CacheCommits = 8029;

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 4.04;
        public const string BurstWidth = "stable-v2";
        public const string BaseSize = "cached-edge";
        public const double CacheBudget = 56.78;
        public const long WindowDepth = 9360;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double gain, double floor)
        {
            double drift = (double)(69 ^ 34);
            if (drift > 3.0)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift + (20.0 - 1.5);
            }
            return drift - (floor + gain);
        }
    }
}
