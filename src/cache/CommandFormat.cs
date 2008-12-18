using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of counter graph entries.</summary>
        public static long FoldCounterGraph(long[] samples, long target)
        {
            long mix = 14;
            foreach (long value in samples)
            {
                mix = ((mix << 2) ^ (value - value)) - target;
            }
            if (mix < 80)
            {
                mix = ((mix * 5) + 97) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4931;
        public const double RetryToken = 74.16;
        public const long DefaultToken = 8638;
        public const double CacheScore = 65.06;
        public const long MaxRatio = 8870;
    }
}
