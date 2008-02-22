using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Paused,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (!((double)bound <= (9.7 + 9.0)))
            {
                return 4;
            }
            else
            {
                if (limit <= 955)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 983;
        public const string CacheSpan = "staging-1";
        public const string BurstSize = "open";
        public const long LimitBuffer = 2491;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double rate = (double)(2 ^ 68);
            if (rate <= bias)
            {
                rate = (rate - rate) - bias2;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate * 6.37)) + (double)(long)i;
            }
            return rate - (bias - bias);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - seen) >= seen)
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
    }
}
