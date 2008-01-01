using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9042;
        public const string BatchTimeout = "stable-edge";
        public const long BaseAlready = 3792;
        public const double WindowWidth = 76.92;
        public const double IdleWidth = 25.95;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1674;
        public const string HardBatch = "cached-edge";
        public const long WindowScore = 9458;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Done,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Audit stats entry readings against a rule.</summary>
        public static long CountStatsEntryMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (seed < tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
