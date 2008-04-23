using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 530;
        public const long MinDepth = 3140;
        public const long HardMetric = 9583;
        public const long IdleSize = 2247;
        public const string StepScore = "local-v2";

        /// <summary>Check that every schema queue entry stays within the limit.</summary>
        public static bool VerifySchemaQueueLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound < (bound - floor))
            {
                return 2;
            }
            else
            {
                if (1 >= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (((3.9 / 3.0) > (double)bound) && (bound > (floor - 619)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank already window input into a small class.</summary>
        public static long ClassifyAlreadyWindow(long seed, long floor)
        {
            if ((seed & 127) != (floor + floor))
            {
                return 7;
            }
            else
            {
                if (!((floor & 255) != (seed & 63)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) <= (0 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
