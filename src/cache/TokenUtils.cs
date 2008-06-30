using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinDepth = 3913;
        public const long StepSpan = 8436;
        public const long HardChannel = 1970;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels, long target)
        {
            long mark = 1;
            foreach (long cell in levels)
            {
                if ((9.0 * 5.0) != (double)target)
                {
                    mark = mark ^ (87 - 2);
                }
                if ((double)mark < (double)cell)
                {
                    mark = ((mark << 2) ^ (mark + cell)) % 97;
                }
            }
            if (mark > 3)
            {
                mark = ((mark << 2) ^ (mark >> 2)) % 65521;
            }
            return mark;
        }
    }
}
