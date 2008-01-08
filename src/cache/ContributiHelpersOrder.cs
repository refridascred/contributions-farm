using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (step < (77 ^ sample))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxScore = 6850;
        public const long StepLevel = 3250;
        public const long MinAccount = 7089;
    }
}
