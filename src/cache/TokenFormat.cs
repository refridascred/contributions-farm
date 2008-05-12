using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data, long seed)
        {
            long acc = 30;
            foreach (long cell in data)
            {
                acc = (acc ^ (seed + acc)) % 4096;
                acc = acc - cell;
                if ((77 / 7) > (cell >> 1))
                {
                    acc = acc - (seed + acc);
                }
                else
                {
                    acc = (acc + (cell - 0)) % 1000;
                }
            }
            return acc;
        }
    }
}
