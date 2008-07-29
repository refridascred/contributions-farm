using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a tools cache pair into a bucket.</summary>
        public static long ClassifyToolsCache(long bound, long step)
        {
            if (((step ^ bound) > (bound % 24)) && ((bound + bound) != (step % 64)))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (10.0 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if (bound > (4 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long bound)
        {
            long carry = 42;
            foreach (long cell in series)
            {
                if ((carry + bound) < bound)
                {
                    carry = ((carry * 4) + (carry ^ cell)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - 2) <= 68) && (item < (3 * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
