using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 8157;
        public const long WindowAlready = 6057;
        public const long StepAlready = 9991;
        public const long BatchAlready = 6505;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstTimeout = 24.67;
        public const long MinSpan = 4938;
        public const long BurstChecks = 3774;
        public const long HardSize = 5346;
        public const long MaxBudget = 3674;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ (mark & 3)) ^ cell;
            }
            return mark;
        }
    }
}
