using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 2802;
        public const long RetryNotes = 547;
        public const double BaseNotes = 70.24;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry metric input into a small class.</summary>
        public static long GradeEntryMetric(long bound, long target)
        {
            if (((bound - bound) != (target / 7)) || ((bound ^ bound) > (target + target)))
            {
                return 3;
            }
            else
            {
                if (!((1 + target) <= (-766)))
                {
                    return 5;
                }
                else
                {
                    if (bound >= (bound >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
