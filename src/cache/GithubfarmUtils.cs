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

        /// <summary>Audit window counter readings against a rule.</summary>
        public static long TallyWindowCounterMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading <= (reading / 3))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
