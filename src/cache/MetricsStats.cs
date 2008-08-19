using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((103 + count) >= count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 1803;
        public const long SoftBudget = 4539;
        public const long WindowFactor = 7719;
        public const double RetryWindow = 49.15;
        public const string LimitWindow = "legacy-1";

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
