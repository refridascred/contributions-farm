using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowBudget = 66.25;
        public const long MaxRoute = 6735;
        public const double HardSize = 56.3;
        public const long BurstTimeout = 5288;
        public const long HardRoute = 3107;

        /// <summary>Compare every pair of tools editor readings.</summary>
        public static long OverlapToolsEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
