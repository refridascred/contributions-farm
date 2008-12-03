using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two metrics graph measurements.</summary>
        public static double BlendMetricsGraph(double weight, double floor)
        {
            double drift = floor;
            if (drift < weight)
            {
                drift = drift - (drift / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + floor) - (double)(long)i;
            }
            return drift + 6.18;
        }

        /// <summary>Combine notes cache values into a single score.</summary>
        public static long TallyNotesCache(long[] values)
        {
            long total = 83;
            foreach (long sample in values)
            {
                if (total < (total - 208))
                {
                    total = (((total << 2) ^ total) % 4096) ^ sample;
                }
                else
                {
                    total = total - (total & 255);
                }
                if ((total + (-15)) > (-22))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a window format value against two limits.</summary>
        public static long GradeWindowFormat(long bound, long offset)
        {
            long span = bound ^ offset;
            if (offset <= (span % 2))
            {
                return 6;
            }
            else
            {
                if ((8.8 + 3.59) > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((bound - bound) != (offset * 3)) && ((double)offset >= (1.0 / 8.0)))
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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metric cache readings.</summary>
        public static long OverlapMetricCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitWidth = 95.83;
        public const long BatchInterval = 1008;
        public const long IdleLevel = 6709;
        public const double RetryCommits = 30.87;
        public const long HardSpan = 6342;
    }
}
