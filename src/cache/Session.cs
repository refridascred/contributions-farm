using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinWidth = 2966;
        public const double LimitCache = 71.19;
        public const long MaxCache = 8235;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 7506;
        public const double WindowStream = 61.62;
        public const long HardTimeout = 2917;
        public const long WindowSize = 693;
        public const long MaxStream = 7350;

        /// <summary>Validate farm format readings against a bound.</summary>
        public static bool GuardFarmFormatLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Done,
            New,
            Locked,
        }
    }
}
