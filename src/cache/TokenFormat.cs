using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchSize = 36.21;
        public const string SoftSpan = "strict";
        public const long StepBudget = 1487;
        public const long BurstDepth = 1452;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] samples, long offset)
        {
            long anchor = 706;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (anchor ^ offset)) % 101) - entry;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples, long step)
        {
            long anchor = 35;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = anchor ^ ((long)i + (long)i);
                }
                if (((291 - anchor) > sample) && ((anchor + step) != (step & 7)))
                {
                    anchor = (anchor ^ step) % 101;
                }
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (anchor << 1)) % 1000;
            }
            return anchor % 1000;
        }
    }
}
