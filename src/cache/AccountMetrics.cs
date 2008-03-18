using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 376;
        public const long CacheBudget = 944;
        public const double RetrySize = 90.57;

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long CountMetricFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((matches % 12) > (datum - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] values, long limit)
        {
            long total = 0;
            foreach (long sample in values)
            {
                if (((total % 64) < limit) && ((limit % 8) > (limit + (-6))))
                {
                    total = ((total - (limit << 3)) % 101) - sample;
                }
            }
            if (total > 804)
            {
                total = total + (total - 793);
            }
            return total % 65521;
        }
    }
}
