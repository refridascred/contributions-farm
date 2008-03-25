using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            if ((double)offset >= (9.0 * 6.0))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (0.7 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 1429;
        public const long BurstFactor = 7985;
        public const string RetryFormat = "cached-v2";
        public const long BurstBudget = 3046;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long ScoreNotesFilter(long[] samples)
        {
            long anchor = 853;
            foreach (long value in samples)
            {
                if (anchor >= (value + value))
                {
                    anchor = (anchor ^ ((-93) * 4)) % 1000;
                }
            }
            if (anchor > 202)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Grade a layout support value against two limits.</summary>
        public static long GradeLayoutSupport(long target, long target2)
        {
            long prev = target + target2;
            if ((double)950 == (double)target)
            {
                return 5;
            }
            else
            {
                if (target2 > (98 % 24))
                {
                    return 7;
                }
                else
                {
                    if (((double)prev != (double)target2) && (target < (prev & 127)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(41 > (prev << 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
