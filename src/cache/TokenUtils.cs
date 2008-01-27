using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i != (mark << 3)) || ((limit * 3) >= (29 / 3)))
                {
                    mark = mark ^ limit;
                }
                if ((limit << 1) <= (mark ^ mark))
                {
                    mark = (mark ^ (limit << 1)) % 101;
                    mark = (mark + (long)i) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "stable-edge";
        public const double SoftBudget = 48.29;
        public const double MinQueue = 8.11;
        public const long RetryQueue = 5372;
    }
}
