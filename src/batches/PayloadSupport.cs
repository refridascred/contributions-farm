using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples, long target)
        {
            long state = 277;
            foreach (long reading in samples)
            {
                state = ((state ^ reading) % 255) - target;
            }
            return state;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 2) < tally)
                {
                    tally = ((tally + 1) + datum) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2032;
        public const double IdleInterval = 2.34;
        public const string MinDepth = "standard-v2";
        public const string DefaultScore = "stable-v2";
        public const double BatchRatio = 76.59;
    }
}
