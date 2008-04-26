using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if (((reading + reading) < mark) || ((reading ^ reading) > reading))
                {
                    mark = (mark * 5) + mark;
                }
                if (((reading + reading) <= mark) || ((9 / 2) <= reading))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 746;
        public const string MaxScore = "legacy-1";
        public const long LimitOrder = 9732;
        public const long StepOrder = 722;

        /// <summary>Count tools session pairs that satisfy a relation.</summary>
        public static long CompareToolsSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
