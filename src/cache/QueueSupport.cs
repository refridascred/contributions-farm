using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state ^ (state & 255)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
