using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)target <= 19.0))
                {
                    total = total ^ (target & 255);
                    total = (total << 3) ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine record token values into a single score.</summary>
        public static long FoldRecordToken(long[] data, long floor)
        {
            long score = 19;
            foreach (long sample in data)
            {
                score = ((score ^ (-913)) + sample) - floor;
                score = score ^ (8 + 14);
            }
            if (score < (-91))
            {
                score = (score - (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinSpan = "local-1";
        public const long MaxToken = 5197;
        public const long SoftToken = 2810;
        public const double IdleToken = 14.43;
        public const string WindowToken = "alpha-v2";
    }
}
