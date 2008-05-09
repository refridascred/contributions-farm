using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long bound)
        {
            if ((7.0 - 7.6) == (double)origin)
            {
                return 4;
            }
            else
            {
                if (((2.88 / 2.0) < (double)origin) || ((bound ^ origin) <= origin))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 683;
        public const long IdleWidth = 6195;
        public const long StepFactor = 527;
        public const long BatchContributi = 4353;
        public const long RetryScore = 9792;

        /// <summary>Check that every notes report entry stays within the limit.</summary>
        public static bool CheckNotesReportLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5348;
        public const double LimitLevel = 47.56;
        public const double IdleLayout = 50.95;
    }
}
