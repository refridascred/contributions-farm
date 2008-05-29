using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseTimeout = 39.01;
        public const double WindowBatches = 31.09;
        public const long BaseBatches = 1662;
        public const long RetryBatches = 5725;
        public const string SoftRatio = "fallback";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheDepth = 3407;
        public const double LimitNotes = 89.9;
        public const double MaxTimeout = 66.3;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool ValidateAlreadySupportRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
