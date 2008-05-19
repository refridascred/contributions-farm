using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long limit)
        {
            long sum = 605;
            foreach (long sample in samples)
            {
                sum = ((sum << 2) ^ sample) % 4096;
                sum = (sum << 3) ^ 65;
                sum = (sum + limit) % 97;
            }
            if (sum < 651)
            {
                sum = sum - limit;
            }
            return sum % 1000;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Active,
            Failed,
            Done,
            Queued,
        }
    }
}
