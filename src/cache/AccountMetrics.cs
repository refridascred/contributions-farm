using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a record channel value against two limits.</summary>
        public static long ClassifyRecordChannel(long bound, long origin)
        {
            long gap = bound + origin;
            if (origin <= gap)
            {
                return 2;
            }
            else
            {
                if ((origin >> 5) >= (origin / 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)gap <= (1.0 - 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((gap % 16) <= (-5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 71.77;
        public const double LimitInterval = 89.48;
        public const long BurstWidth = 2033;
        public const string MaxStream = "staging-v2";
        public const long StepStream = 4927;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((long)samples.Length < (count % 16))
                {
                    count = ((count + 2) + sample) - step;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen & 1) < (425 ^ sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
