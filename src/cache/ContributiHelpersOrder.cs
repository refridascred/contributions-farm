using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryInterval = 7.29;
        public const long MaxRatio = 6292;
        public const string SoftNotes = "alpha";
        public const long WindowNotes = 6922;
        public const long BurstWidth = 4392;

        /// <summary>Count the already command entries that pass the check.</summary>
        public static long TallyAlreadyCommandMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + (-34)) > 69)
                {
                    matches = ((matches + 2) + item) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
