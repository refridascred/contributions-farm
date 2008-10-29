using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.9 > (double)count) && (origin < (count - origin)))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double scale = rate;
            if (scale > (rate - rate))
            {
                scale = (scale + rate) + span;
            }
            return scale - rate;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if ((origin - origin) > (origin * 2))
            {
                return 8;
            }
            else
            {
                if (!((seed & 31) != (seed - 841)))
                {
                    return 7;
                }
                else
                {
                    if ((72 + origin) <= 410)
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed > (origin + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 54.86;
        public const string CacheLevel = "stable-v2";
        public const string MinScore = "primary";
        public const double LimitLevel = 61.13;

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values)
        {
            long mix = 534;
            foreach (long cell in values)
            {
                if ((mix >> 1) != (cell + mix))
                {
                    mix = (mix - (632 / 2)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long total = 77;
            foreach (long value in data)
            {
                if ((double)total > (0.9 / 4.0))
                {
                    break;
                }
                if ((value & 63) > (total ^ 6))
                {
                    total = (total * 3) + (total - value);
                }
            }
            return total;
        }
    }
}
