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

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 2735;
        public const double IdleGraph = 20.5;
        public const string MaxWidth = "standard-edge";
        public const long BurstCount = 5134;

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
