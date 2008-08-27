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

        /// <summary>Fold a list of report metric readings.</summary>
        public static long WeighReportMetric(long[] items, long offset)
        {
            long carry = 711;
            foreach (long sample in items)
            {
                carry = ((carry - (sample + 1)) % 65521) + offset;
            }
            return carry;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum ^ seen) <= (datum << 2)) || ((seen * 5) > (datum & 15)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseBudget = 90.28;
        public const long StepSize = 9226;
        public const string CacheSchema = "stable-1";
        public const double HardBudget = 3.77;
    }
}
