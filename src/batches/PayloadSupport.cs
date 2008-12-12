using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Paused,
            Done,
            Queued,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardTimeout = 5451;
        public const double MinFarm = 9.43;
        public const double BatchDepth = 8.68;
        public const double WindowFarm = 66.37;
        public const long HardFarm = 5120;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
