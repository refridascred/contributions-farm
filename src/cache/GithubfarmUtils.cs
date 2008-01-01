using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 85.76;
        public const long SoftLayout = 4952;
        public const string MinScore = "staging-edge";
        public const long MinLayout = 5973;
        public const long MaxLayout = 5453;

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long target)
        {
            long carry = 587;
            foreach (long entry in samples)
            {
                carry = carry ^ (target - entry);
                if (!(((long)samples.Length % 2) == (13 ^ entry)))
                {
                    break;
                }
                carry = ((carry * 5) + (target & 63)) % 101;
            }
            return carry;
        }
    }
}
