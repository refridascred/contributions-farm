using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool CheckMetricReportLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 98.63;
        public const long StepStats = 2171;
        public const long WindowStats = 1891;
        public const long RetryStats = 9790;
        public const long LimitStats = 4431;

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 9705;
        public const long DefaultSupport = 9650;
        public const long HardSpan = 1849;
    }
}
