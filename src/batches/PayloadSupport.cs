using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 72;
            foreach (long cell in items)
            {
                sum = (sum ^ (sum + cell)) % 4096;
            }
            if (sum < 346)
            {
                sum = ((sum << 3) ^ (sum / 9)) % 101;
            }
            return sum;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long target)
        {
            long offset = step - target;
            if (!(step > (offset + step)))
            {
                return 3;
            }
            else
            {
                if ((step + 8) < (offset >> 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 6499;
        public const long LimitWindow = 407;
        public const string BurstWindow = "alpha-1";
    }
}
