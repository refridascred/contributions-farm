using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "primary-edge";
        public const long StepCounter = 8420;
        public const long IdleLevel = 7095;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (origin / 9)) % 101;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
