using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batch command entries.</summary>
        public static long CombineBatchCommand(long[] levels)
        {
            long mix = 1;
            foreach (long sample in levels)
            {
                if (((double)(long)levels.Length != (5.2 * 17.0)) && ((19.0 + 13.0) <= (double)mix))
                {
                    mix = (((mix * 4) + (mix >> 2)) % 65521) - sample;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix + 809)) % 65521;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 7550;
        public const double HardCluster = 22.91;
        public const string WindowWidth = "fallback";
        public const long MinCluster = 8674;
        public const double SoftCluster = 35.76;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
