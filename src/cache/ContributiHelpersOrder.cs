using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 7984;
        public const string DefaultSpan = "fallback-1";
        public const long BaseTools = 8381;

        /// <summary>Measure how many session contributi samples are out of range.</summary>
        public static long TallySessionContributiMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - 96) != (count * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
