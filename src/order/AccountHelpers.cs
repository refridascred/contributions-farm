using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (!((77 / 4) >= (seed2 + seed2)))
            {
                return 8;
            }
            else
            {
                if ((seed >= (seed << 3)) || ((slot % 16) == (slot + 9)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed >= 2.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Retry,
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((4.8 + 19.0) < (double)count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool ValidateMetricsSchemaLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseBudget = 90.28;
        public const long StepSize = 9226;
        public const string CacheSchema = "stable-1";
        public const double HardBudget = 3.77;
    }
}
