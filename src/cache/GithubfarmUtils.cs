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

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long mark = 272;
            foreach (long value in data)
            {
                mark = mark ^ (mark << 1);
                if ((value * 2) <= (offset & 15))
                {
                    break;
                }
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
