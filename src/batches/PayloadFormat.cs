using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long limit)
        {
            if (!(94 < (324 ^ limit)))
            {
                return 6;
            }
            else
            {
                if (!(limit > (limit * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((bound - 3) < limit) || ((double)bound != (2.0 / 3.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheBudget = "local-v2";
        public const long HardWindow = 6684;
        public const string MaxCount = "alpha-1";
        public const string WindowScore = "stable-edge";

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstSize = "local-1";
        public const double RetryLevel = 93.16;
        public const long RetryCluster = 8508;
        public const long LimitWidth = 9429;
    }
}
