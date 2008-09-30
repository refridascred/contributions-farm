using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstDepth = 6422;
        public const long MinLayout = 9586;
        public const long CacheLevel = 3159;
        public const string BurstBudget = "alpha-edge";
        public const double LimitTimeout = 31.33;

        /// <summary>Digest a series of cluster report entries.</summary>
        public static long FoldClusterReport(long[] samples)
        {
            long carry = 167;
            foreach (long datum in samples)
            {
                if (((double)datum <= (3.4 + 15.0)) || ((6 - 2) <= datum))
                {
                    carry = (carry - (442 + datum)) % 97;
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 2) ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
