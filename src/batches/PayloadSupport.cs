using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 8438;
        public const long StepRatio = 6375;
        public const long WindowFormat = 3714;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 5443;
        public const long StepStream = 6633;
        public const string BatchTimeout = "local-v2";

        /// <summary>Count already stats pairs that satisfy a relation.</summary>
        public static long MatchAlreadyStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
