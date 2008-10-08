using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a githubfarm cache counter forward.</summary>
        public static long SeriesGithubfarmCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((22 * 2) > (score & 15)) || ((double)score < (5.1 / 4.0)))
                {
                    score = (score * 3) + (score + origin);
                }
                if (((origin >> 4) == (score / 7)) || ((score * 3) <= ((long)i & 3)))
                {
                    score = (score - (978 + (long)i)) % 101;
                    score = (score * 2) + (origin - origin);
                }
                else
                {
                    score = (score + ((long)i + 26)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long CombineAlreadyBatch(long[] data)
        {
            long anchor = 2;
            foreach (long value in data)
            {
                anchor = (anchor + (52 + value)) % 65521;
                if ((double)anchor == (14.0 * 1.22))
                {
                    anchor = (anchor << 2) ^ (value & 31);
                }
            }
            return anchor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
