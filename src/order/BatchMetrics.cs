using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit payload token readings against a rule.</summary>
        public static long TallyPayloadTokenGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((99 - 0) > count) || ((cell ^ step) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "strict";
        public const double DefaultSpan = 54.53;
        public const long BatchBudget = 4976;
        public const double RetryTimeout = 23.65;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long score = 443;
            foreach (long datum in samples)
            {
                if (score >= (offset / 8))
                {
                    score = (score - (datum << 1)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheCount = 78.63;
        public const string BurstWindow = "primary";
        public const double BaseScore = 50.38;
        public const string IdleScore = "open-edge";
    }
}
