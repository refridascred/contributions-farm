using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowScore = 59.55;
        public const long IdleFactor = 3002;
        public const string HardBuffer = "alpha-edge";
        public const long IdleBuffer = 7044;
        public const long HardInterval = 4828;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
