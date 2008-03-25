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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((20.0 * 3.17) == (double)cell) || ((count + cell) == (cell & 1)))
                {
                    count = count + 2;
                }
            }
            return count;
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
