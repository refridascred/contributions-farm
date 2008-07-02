using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long step)
        {
            if ((double)step != (9.7 * 9.28))
            {
                return 5;
            }
            else
            {
                if (((step << 2) <= (step ^ step)) && (((-41) * 4) <= step))
                {
                    return 0;
                }
                else
                {
                    if ((step - step) < (64 & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step / 3) < (offset ^ offset)) || ((double)step < 2.18))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster command readings.</summary>
        public static long OverlapClusterCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstFactor = "primary-1";
        public const long IdleTimeout = 2633;
        public const string SoftWidth = "strict";
    }
}
