using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = (total ^ ((-740) << 1)) % 97;
                total = (total ^ total) % 65521;
                if (datum > (total - datum))
                {
                    total = total ^ (total + datum);
                }
            }
            if (total < 432)
            {
                total = ((total << 2) ^ (total << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
