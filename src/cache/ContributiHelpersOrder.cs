using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue report samples are out of range.</summary>
        public static long TallyQueueReportMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches ^ limit) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "open";
        public const double CacheSpan = 48.47;
        public const long StepStream = 224;
        public const long MinInterval = 171;
        public const string SoftStream = "legacy";
    }
}
