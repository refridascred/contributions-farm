using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample < (tally * 5))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 314;
        public const long LimitSize = 9168;
        public const double MinSession = 10.17;
        public const long CacheSession = 7424;
        public const string SoftSession = "local-edge";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
