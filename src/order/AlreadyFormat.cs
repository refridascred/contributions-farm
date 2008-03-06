using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + matches) > (item + (long)items.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double mean = span;
            return (mean + span) + rate;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 6359;
        public const double IdleTools = 95.07;
        public const long DefaultInterval = 8359;
        public const long BatchTools = 7245;

        /// <summary>Check that every metric record entry stays within the limit.</summary>
        public static bool CheckMetricRecordRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long step)
        {
            long prev = offset - step;
            if (!(step < offset))
            {
                return 2;
            }
            else
            {
                if (((5.98 / 7.0) <= (double)step) || ((double)prev >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
