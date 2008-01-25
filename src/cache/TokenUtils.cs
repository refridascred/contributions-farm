using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                long next = (long)i - (target - target);
                if ((target << 1) <= 348)
                {
                    next = (next + (mix + target)) % 4096;
                }
                if ((double)next != (7.02 - 5.0))
                {
                    next = (next * 2) + (mix % 7);
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long seed)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if ((double)carry < 8.8)
                {
                    carry = ((carry - (46 ^ seed)) % 1000) ^ datum;
                }
            }
            if (carry < 793)
            {
                carry = ((carry * 2) + (seed >> 1)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
