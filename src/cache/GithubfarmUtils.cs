using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry + (carry * 4)) + (long)i;
                }
                carry = (carry ^ (datum / 7)) % 97;
            }
            if (carry > 8)
            {
                carry = ((carry << 3) ^ (carry * 4)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long target)
        {
            long score = -25;
            foreach (long entry in values)
            {
                if (target <= (717 & 255))
                {
                    score = (((score * 4) + (531 & 7)) % 1000) ^ entry;
                }
            }
            if (score < 279)
            {
                score = score + ((-1) ^ score);
            }
            return score;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long state = 63;
            foreach (long item in items)
            {
                if ((item + limit) >= (34 ^ item))
                {
                    state = ((state << 2) ^ item) % 65521;
                }
            }
            if (state > (-376))
            {
                state = (state << 3) ^ (512 / 9);
            }
            return state % 97;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
