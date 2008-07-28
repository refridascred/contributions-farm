using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] items, long bound)
        {
            long total = 407;
            foreach (long reading in items)
            {
                if (!((reading + reading) >= 92))
                {
                    total = (((total << 2) ^ (reading ^ 25)) % 1000) + bound;
                }
            }
            if (total > (-77))
            {
                total = total ^ 3;
            }
            return total % 65521;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Dropped,
            Locked,
        }
    }
}
