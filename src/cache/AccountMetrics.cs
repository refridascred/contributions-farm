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

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long seed)
        {
            long carry = 315;
            foreach (long sample in readings)
            {
                carry = (((carry << 3) ^ carry) - sample) - seed;
            }
            return carry;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double load = scale * 5.98;
            if (load >= (double)23)
            {
                load = load + (span + load);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + 0.98;
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
