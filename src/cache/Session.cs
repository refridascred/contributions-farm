using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next filter batches value from a seed.</summary>
        public static long DeriveFilterBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 5415;
        public const long SoftTimeout = 21;
        public const string HardCommits = "stable-edge";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples, long limit)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if ((limit + limit) <= 23)
                {
                    continue;
                }
                if ((7 >> 1) == (score & 63))
                {
                    score = (((score * 4) + 684) % 65521) + sample;
                }
            }
            return score;
        }
    }
}
