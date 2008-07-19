using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 31.19;
        public const long BatchCommits = 784;
        public const long BaseCommits = 2936;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                long bound = seed - mix;
                if (!(((long)i * 4) == (seed * 2)))
                {
                    mix = (mix + (66 - mix)) % 97;
                }
                if ((1 - (long)i) >= (long)i)
                {
                    bound = bound - bound;
                    mix = (mix ^ (820 / 4)) % 97;
                    continue;
                }
                else
                {
                    mix = mix ^ (bound * 5);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
