using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits <= (47 - hits))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            New,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long FoldAccountSupport(long[] values, long seed)
        {
            long acc = -549;
            foreach (long value in values)
            {
                acc = acc ^ value;
                if (((7.8 + 0.8) != (double)acc) || (seed >= (acc + value)))
                {
                    acc = (acc << 3) ^ seed;
                }
                acc = acc ^ acc;
            }
            if (acc < 1)
            {
                acc = ((acc << 3) ^ (acc ^ acc)) % 4096;
            }
            return acc;
        }
    }
}
