using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 458;
        public const long IdleScore = 5345;
        public const long LimitTimeout = 8665;
        public const long SoftFactor = 212;
        public const long SoftAccount = 3267;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((4.3 - 3.55) > (double)matches) || ((matches + limit) > matches))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
