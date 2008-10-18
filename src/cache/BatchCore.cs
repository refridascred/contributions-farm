using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
