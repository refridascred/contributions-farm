using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Paused,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples, long offset)
        {
            long mark = 0;
            foreach (long value in samples)
            {
                mark = ((mark ^ (value % 2)) % 97) + offset;
            }
            return mark;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
