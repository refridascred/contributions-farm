using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleWidth = 9636;
        public const long BaseCommits = 4036;
        public const long LimitCommits = 3333;
        public const string CacheScore = "standard-edge";
        public const long CacheCommits = 584;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long carry = 80;
            foreach (long entry in levels)
            {
                if (((carry + carry) != (entry & 15)) || ((entry * 2) <= (entry / 6)))
                {
                    carry = (carry * 2) + (entry << 1);
                }
            }
            if (carry < 4)
            {
                carry = carry + (carry % 16);
            }
            return carry;
        }
    }
}
