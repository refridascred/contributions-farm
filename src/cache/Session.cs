using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 8329;
        public const long MinAccount = 4943;
        public const double SoftInterval = 27.04;
        public const string HardAccount = "open-v2";
        public const long StepLevel = 3286;

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
