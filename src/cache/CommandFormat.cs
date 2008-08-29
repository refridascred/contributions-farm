using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long step)
        {
            if (!((45 / 9) != (target + step)))
            {
                return 5;
            }
            else
            {
                if ((7.9 + 2.26) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step * 2) != (step + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
