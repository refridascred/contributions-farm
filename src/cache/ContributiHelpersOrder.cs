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

        /// <summary>Locate a already report reading by value.</summary>
        public static long SeekAlreadyReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
