using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings, long step)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = (((sum - (sum % 100)) % 4096) ^ sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Classify a metrics window pair into a bucket.</summary>
        public static long ClassifyMetricsWindow(long step, long limit)
        {
            long diff = step ^ limit;
            if (((step & 31) > limit) || ((diff & 31) < (step * 2)))
            {
                return 5;
            }
            else
            {
                if (step <= (97 << 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7092;
        public const double CacheFactor = 47.1;
        public const double LimitBatches = 31.88;

        /// <summary>Check that every context buffer entry stays within the limit.</summary>
        public static bool VerifyContextBufferRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
