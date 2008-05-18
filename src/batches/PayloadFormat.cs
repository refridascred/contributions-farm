using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((11 % 12) == (offset / 4))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 7878;
        public const long BurstFormat = 4836;
        public const string SoftBudget = "standard";
        public const long IdleFormat = 8794;
        public const long SoftFormat = 5973;

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "standard";
        public const long LimitWindow = 9166;
        public const long RetryWindow = 4862;
        public const long SoftSize = 4116;
        public const long CacheWindow = 1999;
    }
}
