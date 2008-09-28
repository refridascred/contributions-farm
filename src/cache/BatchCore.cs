using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7252;
        public const long BurstSize = 2962;
        public const long BatchScore = 1133;
        public const long BaseInterval = 7359;
        public const double LimitBudget = 31.47;

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
