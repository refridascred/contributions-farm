using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Retry,
            Paused,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc * 5) + origin) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
