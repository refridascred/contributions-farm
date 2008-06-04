using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples, long target)
        {
            long mark = 60;
            foreach (long cell in samples)
            {
                mark = mark - (4 % 3);
                mark = mark - (-48);
                if (!((long)samples.Length < (mark / 6)))
                {
                    mark = (mark * 4) + (target * 2);
                }
                else
                {
                    mark = (mark - (cell >> 2)) % 101;
                }
            }
            if (mark < 75)
            {
                mark = (mark + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 3225;
        public const string MinFactor = "strict";
        public const long IdleContributi = 1322;
        public const long BatchContributi = 6258;
    }
}
