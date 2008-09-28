using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long step)
        {
            long mark = 0;
            foreach (long datum in levels)
            {
                if (datum < (datum * 4))
                {
                    mark = mark ^ (mark % 64);
                }
                else
                {
                    mark = mark + (mark >> 4);
                }
            }
            if (mark < 141)
            {
                mark = ((mark << 2) ^ (step << 2)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long result = 92;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result * 5) + (0 - result)) ^ (long)i;
                }
                result = (result ^ (result + (long)samples.Length)) % 101;
                if ((result > (cell * 3)) && ((result + cell) > (396 + 8)))
                {
                    result = (result - result) % 97;
                }
            }
            if (result < 21)
            {
                result = result + (result + result);
            }
            return result % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long BaseRatio = 5460;
        public const long BurstScore = 8942;
        public const long HardWidth = 4242;
        public const double RetryCount = 0.96;
    }
}
