using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "stable-v2";
        public const long SoftFactor = 9986;
        public const long BurstWidth = 9515;
        public const string CacheScore = "cached-1";

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double gain = (ratio - floor) * 7.2;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (floor * 9.0)) + (double)(long)i;
            }
            return gain - (double)(-3);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits > (hits & 1))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate graph record samples.</summary>
        public static long DigestGraphRecord(long[] levels, long seed)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - 396) ^ (long)i;
                }
                mix = (mix ^ (seed ^ seed)) % 1000;
                if ((mix + cell) <= cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
