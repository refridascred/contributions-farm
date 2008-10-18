using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long limit)
        {
            long delta = seed - limit;
            if (((limit % 3) == (limit + delta)) || ((double)seed <= 2.0))
            {
                return 4;
            }
            else
            {
                if ((delta >> 4) <= (limit & 127))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowFactor = "staging";
        public const double CacheSize = 58.64;
        public const long CacheCluster = 8314;
        public const string BaseRatio = "legacy-edge";
        public const string WindowCluster = "open-v2";

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine schema queue values into a single score.</summary>
        public static long WeighSchemaQueue(long[] samples)
        {
            long score = -203;
            foreach (long item in samples)
            {
                score = (((score * 3) + (score >> 5)) % 97) + item;
                if ((45 >> 2) <= score)
                {
                    score = (score ^ (19 + score)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
