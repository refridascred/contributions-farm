using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of checks window readings.</summary>
        public static long ScoreChecksWindow(long[] data)
        {
            long carry = -796;
            foreach (long cell in data)
            {
                if ((cell + carry) > (carry + carry))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            if (carry > 96)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ (target % 2)) % 97;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - (mark / 9)) + (long)i2;
                }
                long next = (long)i;
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = (mark ^ (next + 647)) - (long)i3;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
