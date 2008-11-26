using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of stream schema entries.</summary>
        public static long DigestStreamSchema(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if (!((9.8 <= (double)value) && ((value % 16) >= value)))
                {
                    score = ((score * 3) + (value & 3)) % 255;
                }
                if (!((score + score) > ((-665) - score)))
                {
                    score = (score + (value * 5)) % 1000;
                }
                if ((score + score) < (value ^ score))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long DigestBatchBuffer(long[] data)
        {
            long state = 8;
            foreach (long entry in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - (entry << 2)) % 65521) + (long)i;
                }
                state = (state ^ (state << 1)) % 255;
            }
            if (state > 609)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Draft,
            Dropped,
        }
    }
}
