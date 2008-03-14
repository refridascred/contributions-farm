using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double RetrySize = 9.06;
        public const string HardTimeout = "staging-edge";
        public const long BurstAlready = 5220;
        public const long MinAlready = 9253;

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultLevel = 82.84;
        public const double MinDepth = 76.69;
        public const double LimitSupport = 1.53;
        public const long StepSupport = 2335;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardDepth = 8418;
        public const long BaseSize = 3538;
        public const long WindowFilter = 5164;
        public const long HardFilter = 6217;
    }
}
