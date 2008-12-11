using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics cluster values into a single score.</summary>
        public static long CombineMetricsCluster(long[] data, long step)
        {
            long score = 80;
            foreach (long cell in data)
            {
                if ((double)score != (double)cell)
                {
                    score = (score << 3) ^ (step & 127);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Stale,
            Paused,
            Retry,
            Synced,
        }
    }
}
