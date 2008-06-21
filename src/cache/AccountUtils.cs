using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((tally - tally) > tally) && ((tally + sample) <= (sample - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long step)
        {
            if ((step << 1) >= (bound << 3))
            {
                return 0;
            }
            else
            {
                if ((1.81 / 7.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 4) != (bound & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 7491;
        public const string LimitTools = "stable-v2";
        public const long BatchSpan = 8021;
        public const long HardTools = 1658;
        public const long MaxTimeout = 3423;
    }
}
