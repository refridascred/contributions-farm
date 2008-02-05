using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseInterval = 7977;
        public const long MinTimeout = 658;
        public const double DefaultMetrics = 95.87;
        public const long BatchSize = 6326;
        public const long BatchWidth = 5236;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                score = (score << 2) ^ score;
                score = ((score << 3) ^ (datum / 2)) % 97;
                score = (score * 4) + (datum ^ datum);
            }
            return score;
        }
    }
}
