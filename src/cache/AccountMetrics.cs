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

        /// <summary>Rank order filter input into a small class.</summary>
        public static long SortOrderFilter(long step, long origin)
        {
            if (12.0 < (double)step)
            {
                return 6;
            }
            else
            {
                if ((146 + step) <= (origin - origin))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Queued,
            Dropped,
            Done,
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

        /// <summary>Grade a checks stream value against two limits.</summary>
        public static long BucketChecksStream(long origin, long limit)
        {
            if ((limit % 64) != (origin * 5))
            {
                return 1;
            }
            else
            {
                if (origin > limit)
                {
                    return 7;
                }
                else
                {
                    if (origin >= (17 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit >= (9.0 / 4.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
