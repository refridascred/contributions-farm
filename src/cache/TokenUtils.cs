using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels, long floor)
        {
            long sum = 232;
            foreach (long cell in levels)
            {
                if (!((sum - cell) < (sum & 3)))
                {
                    sum = sum ^ (floor / 3);
                }
            }
            if (sum > 248)
            {
                sum = ((sum << 2) ^ (floor ^ sum)) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (203 * 3)) % 255;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
