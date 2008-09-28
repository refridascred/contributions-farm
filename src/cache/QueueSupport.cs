using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Draft,
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Iterate the farm layout series from a seed.</summary>
        public static long RollFarmLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
