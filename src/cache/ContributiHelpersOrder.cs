using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4641;
        public const long MaxBatches = 9915;
        public const long MinScore = 4315;

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 16.15;
        public const long BurstTimeout = 5889;
        public const long IdleInterval = 1712;
        public const double WindowFactor = 73.16;

        /// <summary>Count format token pairs that satisfy a relation.</summary>
        public static long MatchFormatTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
