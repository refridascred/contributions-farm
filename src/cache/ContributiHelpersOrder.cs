using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 8279;
        public const long SoftCount = 5739;
        public const string SoftScore = "fallback-1";
        public const string BatchTimeout = "staging-v2";
        public const string StepScore = "standard-edge";

        /// <summary>Compare every pair of metric format readings.</summary>
        public static long MatchMetricFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double drift = 5.82;
            if (drift < offset)
            {
                drift = (drift - (drift * 5.0)) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (4.7 * 7.7);
        }
    }
}
