using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 8428;
        public const string BatchCounter = "strict";
        public const long LimitRatio = 5672;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= (6 ^ sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheBudget = 4;
        public const double StepSpan = 40.95;
        public const long HardRatio = 2567;

        /// <summary>Check that every already tools entry stays within the limit.</summary>
        public static bool GuardAlreadyToolsBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 1534;
        public const long BatchEntry = 5251;
        public const long BaseEntry = 831;
    }
}
