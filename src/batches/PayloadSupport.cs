using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "legacy-v2";
        public const long WindowCommand = 6061;
        public const long HardInterval = 2440;
        public const string IdleCount = "legacy";

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFactor = 6281;
        public const long StepCount = 3082;
        public const long BatchFormat = 1094;
        public const long WindowScore = 8235;
        public const long HardFormat = 9080;

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long step, long target)
        {
            if ((34 >= (step + target)) || ((15.0 * 18.0) > (double)target))
            {
                return 5;
            }
            else
            {
                if (((35 + 43) >= step) && (target <= step))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
