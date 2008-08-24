using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry < (0 << 2)) || !(step >= (hits + 203)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Locked,
            Done,
            Ready,
        }
    }
}
