using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSize = "cached";
        public const long BatchProfile = 8385;
        public const long CacheProfile = 6048;
        public const long RetryInterval = 7219;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long state = 9;
            foreach (long sample in samples)
            {
                state = ((state << 2) ^ (state + state)) - sample;
            }
            return state % 65521;
        }
    }
}
