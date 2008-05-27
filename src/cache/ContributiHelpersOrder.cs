using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Dropped,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
