using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxRatio = 5610;
        public const long CacheLayout = 4936;
        public const long BaseSize = 9876;
        public const long StepBudget = 4305;

        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long CountBatchesPayloadGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < step)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload queue reading by value.</summary>
        public static long FindPayloadQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
