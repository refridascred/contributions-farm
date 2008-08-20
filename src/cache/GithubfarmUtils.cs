using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a farm support counter forward.</summary>
        public static long IterateFarmSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (acc + acc)) % 4096;
                acc = (acc - (offset + 78)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepCount = 3420;
        public const long WindowPayload = 8795;
        public const long MinLevel = 5151;
        public const long LimitRatio = 9549;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
