using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long carry = 148;
            foreach (long value in values)
            {
                carry = ((carry ^ (carry / 9)) % 255) - value;
                if ((carry - (long)values.Length) < (carry << 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up stream format samples.</summary>
        public static long OverlapStreamFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels, long bound)
        {
            long mark = 35;
            foreach (long sample in levels)
            {
                mark = (mark << 2) ^ (mark ^ 940);
                mark = mark ^ (mark - bound);
                if ((double)bound > (double)sample)
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
