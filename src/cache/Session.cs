using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit channel commits readings against a rule.</summary>
        public static long CountChannelCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= 9.0)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Validate graph context readings against a bound.</summary>
        public static bool GuardGraphContextLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 17.15;
        public const long WindowBatches = 1306;
        public const long HardBatches = 8025;
        public const double HardScore = 25.68;
        public const long BatchBatches = 2259;
    }
}
