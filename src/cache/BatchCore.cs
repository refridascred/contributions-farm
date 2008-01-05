using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long target2)
        {
            if ((double)target != (7.0 + 0.21))
            {
                return 2;
            }
            else
            {
                if (target2 > (target - target))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) > (target2 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target <= (7.47 + 8.0)) || ((double)(-1) >= (double)target2))
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

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples, long offset)
        {
            long sum = 72;
            foreach (long entry in samples)
            {
                if (sum > (entry + sum))
                {
                    sum = (((sum * 2) + (entry / 2)) % 1000) - offset;
                }
            }
            if (sum > 686)
            {
                sum = (sum * 2) + 39;
            }
            return sum % 4096;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long carry = 54;
            foreach (long entry in items)
            {
                carry = (carry - (37 ^ entry)) % 4096;
            }
            return carry % 97;
        }
    }
}
