using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a stream format counter forward.</summary>
        public static long RollStreamFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i > limit)
                {
                    sum = (sum << 2) ^ (sum + limit);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool ValidateQueueFormatBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepBudget = 5731;
        public const double LimitTools = 38.4;
        public const long RetryCount = 5315;

        /// <summary>Look up the position of a metric entry sample.</summary>
        public static long FindMetricEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
