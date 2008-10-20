using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ ((long)i - total);
                total = ((total << 2) ^ (total + 7)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7466;
        public const long WindowBudget = 4271;
        public const long BatchMetric = 1548;
        public const double BatchSpan = 86.75;
        public const long MinRatio = 5244;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long acc = 995;
            foreach (long item in samples)
            {
                if (((-1) + 19) < (acc - limit))
                {
                    acc = ((acc << 2) ^ limit) + item;
                }
                else
                {
                    acc = (acc + (19 + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
