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

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchSpan = 4898;
        public const double BaseCounter = 59.65;
        public const string BaseWidth = "strict-edge";
        public const long HardCount = 4030;

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
