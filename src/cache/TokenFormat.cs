using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "strict-1";
        public const string HardInterval = "alpha-edge";
        public const long StepReport = 8255;
        public const double CacheSpan = 29.57;

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
