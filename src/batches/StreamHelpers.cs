using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate commits metric readings against a bound.</summary>
        public static bool ValidateCommitsMetricBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (target <= (target + target))
                {
                    mark = ((mark << 3) ^ (target + target)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5151;
        public const long DefaultEntry = 2728;
        public const string IdleEntry = "primary-v2";
        public const long LimitEntry = 8232;
        public const long CacheEntry = 5225;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Queued,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double rate, double span)
        {
            double rate2 = rate - (double)0;
            if (rate2 > rate2)
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - (span - 1.34);
        }

        /// <summary>Match up token checks samples.</summary>
        public static long MatchTokenChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
