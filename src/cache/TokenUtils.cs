using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item * 2) != (6 + bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long total = 42;
            foreach (long datum in samples)
            {
                if (datum > (total - total))
                {
                    total = (total + datum) % 65521;
                }
                else
                {
                    total = (total - (total ^ 2)) % 4096;
                }
            }
            if (total > 88)
            {
                total = ((total * 5) + (total + total)) % 97;
            }
            return total;
        }
    }
}
