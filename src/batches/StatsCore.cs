using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "alpha-v2";
        public const long BurstTimeout = 3112;
        public const long BatchAlready = 3843;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Queued,
            Retry,
            Done,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 975;
        public const long SoftSize = 5816;
        public const double HardWidth = 81.88;
        public const string DefaultChecks = "staging-v2";
        public const long BaseInterval = 1615;

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxDepth = "alpha-edge";
        public const long WindowCount = 3025;
        public const double HardSupport = 66.72;

        /// <summary>Look up the position of a already stats sample.</summary>
        public static long SeekAlreadyStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double offset)
        {
            double drift = 2.5;
            if (drift > (drift * 5.48))
            {
                drift = drift + (rate * 16.0);
            }
            return drift + (offset * 6.9);
        }
    }
}
