using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mark = 511;
            foreach (long cell in samples)
            {
                mark = (mark + (mark ^ cell)) % 101;
                if (4.91 < (double)mark)
                {
                    mark = (mark + (cell + mark)) % 101;
                }
            }
            if (mark > 63)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Accumulate record stream samples.</summary>
        public static long WeighRecordStream(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                carry = ((carry << 2) ^ (636 - offset)) % 101;
                if ((carry / 7) < (offset + value))
                {
                    carry = carry - (carry / 8);
                }
                else
                {
                    carry = ((carry * 5) + (value * 2)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "strict";
        public const double RetryStats = 80.35;
        public const double WindowStats = 73.2;
        public const string WindowSize = "staging";
        public const string BatchStats = "standard-edge";
    }
}
