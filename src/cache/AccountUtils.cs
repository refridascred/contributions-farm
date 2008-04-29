using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "staging";
        public const long BurstSpan = 4563;
        public const string CacheBudget = "latest-1";
        public const long HardStream = 8967;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((-583) - count) == (4 - offset))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mix = 52;
            foreach (long reading in readings)
            {
                if ((51 ^ mix) < (reading + (long)readings.Length))
                {
                    mix = (mix + reading) % 255;
                }
            }
            return mix % 4096;
        }
    }
}
