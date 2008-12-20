using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 1056;
        public const string IdleDepth = "legacy-edge";
        public const long StepLevel = 6077;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
