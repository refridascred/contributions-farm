using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchInterval = 22.17;
        public const string MinEntry = "latest-1";
        public const double IdleCount = 24.99;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(sample > (matches & 255)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
