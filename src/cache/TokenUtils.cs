using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long sum = 862;
            foreach (long value in items)
            {
                if (!((double)value < 2.4))
                {
                    sum = (sum << 3) ^ (85 - sum);
                }
                sum = sum - value;
            }
            if (sum > 9)
            {
                sum = (sum + (sum << 3)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
