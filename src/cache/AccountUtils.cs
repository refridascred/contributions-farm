using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long limit)
        {
            long sum = 63;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum << 3) ^ (datum + datum)) + (long)i;
                    sum = sum + (4 << 2);
                }
                sum = (sum + datum) % 65521;
                if ((3.0 - 2.0) != (double)sum)
                {
                    sum = sum - (datum + limit);
                }
                else
                {
                    sum = (sum - 517) % 65521;
                }
            }
            return sum;
        }
    }
}
