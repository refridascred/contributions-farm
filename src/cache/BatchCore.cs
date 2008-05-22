using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Ready,
            Locked,
            Paused,
            New,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 2701;
        public const long BurstTools = 1521;
        public const string BatchCount = "latest-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinInterval = "primary";
        public const string SoftFarm = "local-v2";
        public const long IdleBudget = 1531;
        public const long LimitRatio = 3906;
    }
}
