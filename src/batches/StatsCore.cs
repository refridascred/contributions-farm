using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 12) < 3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long limit, long step)
        {
            long bound = limit + step;
            if (((limit + bound) >= (bound / 8)) || (8 < (limit / 3)))
            {
                return 7;
            }
            else
            {
                if ((238 < (step + limit)) || ((5.25 - 11.0) > (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (16.0 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardSpan = 8377;
        public const string IdleDepth = "latest-v2";
        public const long MaxContributi = 6530;
        public const double LimitCount = 64.93;
        public const long MaxInterval = 3477;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Failed,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
