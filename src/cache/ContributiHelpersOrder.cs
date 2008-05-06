using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up contributi buffer samples.</summary>
        public static long PairContributiBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if (origin > (long)i)
                {
                    mark = (mark ^ (origin * 4)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseDepth = 3095;
        public const string HardScore = "staging";
        public const long CacheLevel = 3143;
        public const string LimitContributi = "alpha-1";
    }
}
