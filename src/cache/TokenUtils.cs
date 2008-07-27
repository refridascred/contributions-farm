using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] data)
        {
            long carry = -66;
            foreach (long datum in data)
            {
                carry = ((carry * 2) + (datum >> 3)) % 4096;
                if ((double)carry >= (double)datum)
                {
                    carry = ((carry * 2) + 658) % 1000;
                }
                else
                {
                    carry = carry + ((-80) % 64);
                }
                if ((datum ^ carry) > (datum - carry))
                {
                    break;
                }
            }
            if (carry > 825)
            {
                carry = ((carry * 5) + ((-1) % 16)) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long score = 57;
            foreach (long value in series)
            {
                score = (score + (value * 2)) % 97;
                if (8.6 >= (double)score)
                {
                    score = score + (value + 900);
                }
                if (value <= (value ^ score))
                {
                    score = (score + (score * 2)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (score << 1)) % 65521;
                }
                if (4.1 < (double)value)
                {
                    break;
                }
            }
            if (score < (-153))
            {
                score = (score ^ (score << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally ^ limit) <= (limit & 31))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
