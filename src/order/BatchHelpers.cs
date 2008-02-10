using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i + (long)i) >= (origin - (long)i))
                {
                    score = ((score << 2) ^ (410 ^ (long)i)) % 101;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 8591;
        public const long BatchTools = 2530;
        public const string MinSize = "strict-1";
    }
}
