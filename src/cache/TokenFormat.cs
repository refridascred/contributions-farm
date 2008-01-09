using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a buffer githubfarm pair into a bucket.</summary>
        public static long RankBufferGithubfarm(long origin, long target)
        {
            if (79 <= origin)
            {
                return 7;
            }
            else
            {
                if ((origin / 6) < target)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of tools order readings.</summary>
        public static long WeighToolsOrder(long[] levels)
        {
            long anchor = -1;
            foreach (long datum in levels)
            {
                if ((datum - 7) >= (datum >> 4))
                {
                    anchor = (anchor + (anchor * 4)) % 255;
                }
            }
            if (anchor < 11)
            {
                anchor = ((anchor << 3) ^ (2 + anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of stats support readings.</summary>
        public static long TotalStatsSupport(long[] series, long target)
        {
            long carry = 29;
            foreach (long reading in series)
            {
                carry = ((carry + target) % 65521) + reading;
                carry = ((carry << 2) ^ (0 * 3)) % 255;
            }
            return carry;
        }
    }
}
