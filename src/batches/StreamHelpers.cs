using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) == (item ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "strict-1";
        public const long WindowBudget = 8397;
        public const long LimitBuffer = 9282;
        public const long MaxRatio = 7084;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats cluster value against two limits.</summary>
        public static long RankStatsCluster(long step, long origin)
        {
            if (((double)step > (5.6 / 4.0)) || ((18.0 * 4.0) <= (double)step))
            {
                return 8;
            }
            else
            {
                if ((4.0 - 1.0) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < 7.8)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + origin) < origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 63) == (sample / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long target)
        {
            if ((origin < (origin / 2)) || ((double)target <= (6.0 * 8.2)))
            {
                return 0;
            }
            else
            {
                if ((target >> 5) == (origin + origin))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
