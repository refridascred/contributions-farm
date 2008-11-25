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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchFactor = 7545;
        public const string CacheSpan = "strict-1";
        public const double BurstChannel = 20.03;
        public const long DefaultCount = 6474;
        public const double MaxFactor = 33.17;

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

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
