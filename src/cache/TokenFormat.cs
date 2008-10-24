using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long bound)
        {
            long carry = 26;
            foreach (long sample in levels)
            {
                if ((0 + carry) <= sample)
                {
                    carry = (carry ^ (bound - sample)) % 101;
                }
                else
                {
                    carry = (carry + (1 * 5)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool GuardToolsLayoutBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long limit)
        {
            if ((limit << 3) != (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit / 7) < bound)
                {
                    return 3;
                }
                else
                {
                    if (!(limit >= (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
