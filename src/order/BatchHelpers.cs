using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long anchor = 7;
            foreach (long entry in series)
            {
                anchor = (((anchor << 2) ^ (anchor << 3)) % 101) ^ entry;
                if ((8.2 + 15.0) < (double)floor)
                {
                    break;
                }
            }
            if (anchor > 420)
            {
                anchor = (anchor - (floor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2500;
        public const double BatchAccount = 55.88;
        public const string DefaultBudget = "fallback";
        public const long MaxCount = 9301;

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
