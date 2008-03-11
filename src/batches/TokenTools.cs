using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 8) <= hits)
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }
    }
}
