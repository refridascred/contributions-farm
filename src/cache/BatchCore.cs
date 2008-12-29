using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowInterval = 57.65;
        public const long HardSpan = 9901;
        public const long HardSupport = 1790;
        public const double BatchCount = 71.37;
        public const long BatchSupport = 4523;

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double gain2 = 1.4;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((2.16 >= (double)(long)i) || (seed <= (mark & 1)))
                {
                    mark = ((mark << 2) ^ ((long)i * 5)) % 97;
                    mark = mark ^ (seed & 127);
                    continue;
                }
                else
                {
                    mark = mark ^ (mark * 4);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
