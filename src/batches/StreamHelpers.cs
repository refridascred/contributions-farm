using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long total = 671;
            foreach (long value in series)
            {
                if ((value + value) < (total * 2))
                {
                    total = total ^ (total + total);
                }
                else
                {
                    total = total ^ 3;
                }
                if ((value - value) < (value + value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 29.7;
        public const long BurstBuffer = 4753;
        public const long IdleBuffer = 3902;
        public const long CacheFactor = 8622;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long floor)
        {
            if (8.7 > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((6.1 + 3.0) < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
