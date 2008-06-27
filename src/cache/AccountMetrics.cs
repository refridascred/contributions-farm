using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batch window readings against a bound.</summary>
        public static bool GuardBatchWindowLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long origin)
        {
            long cur = target ^ origin;
            if ((double)target != (double)origin)
            {
                return 2;
            }
            else
            {
                if (((origin - cur) >= (target & 127)) && (80 <= (cur ^ origin)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item >= (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches << 3) > value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats counter samples.</summary>
        public static long ScoreStatsCounter(long[] readings, long step)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                anchor = (anchor + step) % 1000;
                if (1.13 >= (double)sample)
                {
                    anchor = (anchor ^ (long)readings.Length) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + (6 + step)) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor * 2) + (step + anchor);
            }
            return anchor;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
